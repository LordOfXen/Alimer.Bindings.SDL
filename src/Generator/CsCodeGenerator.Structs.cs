﻿// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Text;
using CppAst;

namespace Generator;

public static partial class CsCodeGenerator
{
    private static bool generateSizeOfStructs = false;

    private static void CollectStructAndUnions(CppCompilation compilation)
    {
        foreach (CppClass? cppClass in compilation.Classes)
        {
            if (cppClass.ClassKind == CppClassKind.Class ||
                cppClass.SizeOf == 0 ||
                cppClass.Name.EndsWith("_T"))
            {
                continue;
            }

            // Handled manually.
            if (/*cppClass.Name == "SDL_GamepadBinding"
                ||*/ cppClass.Name == "VkTransformMatrixKHR"
                )
            {
                continue;
            }

            s_collectedStructAndUnions.Add(cppClass);
        }
    }

    private static void GenerateStructAndUnions()
    {
        string visibility = s_options.PublicVisiblity ? "public" : "internal";

        // Generate Structures
        using var writer = new CodeWriter(Path.Combine(s_options.OutputPath, "Structs.cs"),
            false,
            s_options.Namespace,
            [
                "System.Runtime.InteropServices",
                "System.Runtime.CompilerServices",
                "System.Diagnostics.CodeAnalysis"
            ],
            "#pragma warning disable CS0649"
            );

        // Print All classes, structs
        foreach (CppClass? cppClass in s_collectedStructAndUnions)
        {
            bool isUnion = cppClass.ClassKind == CppClassKind.Union;

            string csName = cppClass.Name;
            WriteStruct(writer, cppClass, cppClass.Name);
            writer.WriteLine();
        }
    }

    private static void WriteStruct(CodeWriter writer, CppClass @struct, string structName)
    {
        string visibility = s_options.PublicVisiblity ? "public" : "internal";
        bool isUnion = @struct.ClassKind == CppClassKind.Union;
        bool isReadOnly = false;

        if (isUnion)
        {
            writer.WriteLine("[StructLayout(LayoutKind.Explicit)]");
        }
        using (writer.PushBlock($"{visibility} partial struct {structName}"))
        {
            if (generateSizeOfStructs && @struct.SizeOf > 0)
            {
                writer.WriteLine("/// <summary>");
                writer.WriteLine($"/// The size of the <see cref=\"{structName}\"/> type, in bytes.");
                writer.WriteLine("/// </summary>");
                writer.WriteLine($"public static readonly int SizeInBytes = {@struct.SizeOf};");
                writer.WriteLine();
            }

            foreach (CppField cppField in @struct.Fields)
            {
                WriteField(writer, cppField, isUnion, isReadOnly);
            }
        }
    }

    private static void WriteField(CodeWriter writer, CppField field, bool isUnion = false, bool isReadOnly = false)
    {
        string csFieldName = NormalizeFieldName(field.Name);

        if (isUnion)
        {
            writer.WriteLine("[FieldOffset(0)]");
        }

        if (field.Type is CppArrayType arrayType)
        {
            bool canUseFixed = false;
            if (arrayType.ElementType is CppPrimitiveType)
            {
                canUseFixed = true;
            }
            else if (arrayType.ElementType is CppTypedef typedef
                && typedef.ElementType is CppPrimitiveType)
            {
                canUseFixed = true;
            }

            if (canUseFixed)
            {
                string csFieldType = GetCsTypeName(arrayType.ElementType, false);
                writer.WriteLine($"public unsafe fixed {csFieldType} {csFieldName}[{arrayType.Size}];");
            }
            else
            {
                string csFieldType;
                if (arrayType.ElementType is CppArrayType elementArrayType)
                {
                    // vk-video madness
                    csFieldType = GetCsTypeName(elementArrayType.ElementType, false);
                    writer.WriteLine($"public unsafe fixed {csFieldType} {csFieldName}[{arrayType.Size} * {elementArrayType.Size}];");
                }
                else
                {
                    csFieldType = GetCsTypeName(arrayType.ElementType, false);

                    writer.WriteLine($"public {csFieldName}__FixedBuffer {csFieldName};");
                    writer.WriteLine();

                    using (writer.PushBlock($"public unsafe struct {csFieldName}__FixedBuffer"))
                    {
                        for (int i = 0; i < arrayType.Size; i++)
                        {
                            writer.WriteLine($"public {csFieldType} e{i};");
                        }
                        writer.WriteLine();

                        writer.WriteLine("[UnscopedRef]");
                        using (writer.PushBlock($"public ref {csFieldType} this[int index]"))
                        {
                            writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                            using (writer.PushBlock("get"))
                            {
                                if (csFieldType.EndsWith('*'))
                                {
                                    using (writer.PushBlock($"fixed ({csFieldType}* pThis = &e0)"))
                                    {
                                        writer.WriteLine($"return ref pThis[index];");
                                    }
                                }
                                else
                                {
                                    writer.WriteLine($"return ref AsSpan()[index];");
                                }
                            }
                        }
                        writer.WriteLine();

                        if (!csFieldType.EndsWith('*'))
                        {
                            writer.WriteLine("[UnscopedRef]");
                            writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                            using (writer.PushBlock($"public Span<{csFieldType}> AsSpan()"))
                            {
                                writer.WriteLine($"return MemoryMarshal.CreateSpan(ref e0, {arrayType.Size});");
                            }
                        }
                    }
                }
            }
        }
        else if (field.Type is CppClass cppClass)
        {
            string fullParentName = field.FullParentName;
            if (fullParentName.EndsWith("::"))
            {
                fullParentName = fullParentName.Substring(0, fullParentName.Length - 2);
            }
            string csFieldType = $"{fullParentName}_{csFieldName}";
            writer.WriteLine($"public {csFieldType} {csFieldName};");
            writer.WriteLine("");

            WriteStruct(writer, cppClass, csFieldType);
        }
        else
        {
            // VkAllocationCallbacks members
            if (field.Type is CppPointerType pointerType &&
                pointerType.ElementType is CppFunctionType functionType)
            {
                StringBuilder builder = new();
                foreach (CppParameter parameter in functionType.Parameters)
                {
                    string paramCsType = GetCsTypeName(parameter.Type, false);
                    // Otherwise we get interop issues with non blittable types
                    if (paramCsType == "VkBool32")
                        paramCsType = "uint";
                    builder.Append(paramCsType).Append(", ");
                }

                string returnCsName = GetCsTypeName(functionType.ReturnType, false);
                // Otherwise we get interop issues with non blittable types
                if (returnCsName == "VkBool32")
                    returnCsName = "uint";

                builder.Append(returnCsName);

                writer.WriteLine($"public unsafe delegate* unmanaged<{builder}> {csFieldName};");
                return;
            }

            string csFieldType = GetCsTypeName(field.Type, false);

            string fieldPrefix = isReadOnly ? "readonly " : string.Empty;
            if (csFieldType.EndsWith('*'))
            {
                fieldPrefix += "unsafe ";
            }

            //if (field.Comment is not null && string.IsNullOrEmpty(field.Comment.ToString()) == false)
            //{
            //    writer.WriteLine($"/// <summary>{field.Comment}</summary>");
            //}

            writer.WriteLine($"public {fieldPrefix}{csFieldType} {csFieldName};");
        }
    }
}