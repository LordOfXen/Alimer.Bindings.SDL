// Copyright � Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using CppAst;

namespace Generator;

public static partial class CsCodeGenerator
{
    private static readonly HashSet<string> s_keywords = new()
    {
        "object",
        "event",
    };

    private static readonly Dictionary<string, string> s_csNameMappings = new()
    {
        { "bool", "bool" },
        { "uint8_t", "byte" },
        { "uint16_t", "ushort" },
        { "uint32_t", "uint" },
        { "Uint32", "uint" },
        { "uint64_t", "ulong" },
        { "int8_t", "sbyte" },
        { "int32_t", "int" },
        { "int16_t", "short" },
        { "int64_t", "long" },
        { "int64_t*", "long*" },
        { "char", "byte" },
        { "size_t", "nuint" },
        { "intptr_t", "nint" },
        { "uintptr_t", "nuint" },

        { "WGPUSubmissionIndex", "ulong" },
        { "WGPUProc", "nint" },

        { "VGPUDeviceAddress", "ulong" },
        { "VGPUNativeObjectType", "uint" },
    };

    private static CsCodeGeneratorOptions _options = new();

    private static readonly List<CppMacro> s_collectedMacros = new();
    private static readonly List<CppEnum> s_collectedEnums = new();
    private static readonly Dictionary<string, CppFunctionType> s_collectedCallbackTypedes = new();
    private static readonly List<CppFunction> s_collectedFunctions = new();

    public static void Collect(CppCompilation compilation)
    {
        CollectConstants(compilation);
        CollectEnums(compilation);
        CollectCommands(compilation);
    }

    public static void Generate(CppCompilation compilation, CsCodeGeneratorOptions options)
    {
        _options = options;

        GenerateConstants(compilation);
        GenerateEnums(compilation);
        GenerateHandles(compilation);
        GenerateStructAndUnions(compilation);
        GenerateCommands(compilation);
    }

    public static void AddCsMapping(string typeName, string csTypeName)
    {
        s_csNameMappings[typeName] = csTypeName;
    }

    private static void CollectConstants(CppCompilation compilation)
    {
        foreach (CppMacro cppMacro in compilation.Macros)
        {
            if (string.IsNullOrEmpty(cppMacro.Value)
                || cppMacro.Name.EndsWith("_H_", StringComparison.OrdinalIgnoreCase)
                || cppMacro.Name.Equals("SDL_SCANCODE_TO_KEYCODE", StringComparison.OrdinalIgnoreCase)
                )
            {
                continue;
            }

            s_collectedMacros.Add(cppMacro);
        }
    }

    private static void GenerateConstants(CppCompilation compilation)
    {
        string visibility = _options.PublicVisiblity ? "public" : "internal";
        using var writer = new CodeWriter(Path.Combine(_options.OutputPath, "Constants.cs"), false, _options.Namespace, Array.Empty<string>());
        using (writer.PushBlock($"{visibility} static partial class {_options.ClassName}"))
        {
            foreach (CppMacro cppMacro in s_collectedMacros)
            {
                //string csName = GetPrettyEnumName(cppMacro.Name, "VK_");

                string modifier = "const";
                string csDataType = "string";
                string macroValue = NormalizeEnumValue(cppMacro.Value);
                if (macroValue.EndsWith("F", StringComparison.OrdinalIgnoreCase))
                {
                    csDataType = "float";
                }
                else if (macroValue.EndsWith("UL", StringComparison.OrdinalIgnoreCase))
                {
                    csDataType = "ulong";
                }
                else if (macroValue.EndsWith("U", StringComparison.OrdinalIgnoreCase))
                {
                    csDataType = "uint";
                }
                else if (uint.TryParse(macroValue, out _) || macroValue.StartsWith("0x"))
                {
                    csDataType = "uint";
                }
                else if (macroValue.Contains("<<"))
                {
                    csDataType = "int";
                }

                if (cppMacro.Name == "WGPU_WHOLE_MAP_SIZE")
                {
                    modifier = "static readonly";
                    csDataType = "nuint";
                    macroValue = "nuint.MaxValue";
                }

                writer.WriteLine($"/// <unmanaged>{cppMacro.Name}</unmanaged>");
                if (cppMacro.Name == "VK_HEADER_VERSION_COMPLETE")
                {
                    writer.WriteLine($"public {modifier} {csDataType} {cppMacro.Name} = new VkVersion({cppMacro.Tokens[2]}, {cppMacro.Tokens[4]}, {cppMacro.Tokens[6]}, VK_HEADER_VERSION);");
                }
                else
                {
                    writer.WriteLine($"public {modifier} {csDataType} {cppMacro.Name} = {macroValue};");
                }
            }
        }
    }

    private static string NormalizeFieldName(string name)
    {
        if (s_keywords.Contains(name))
            return "@" + name;

        return name;
    }

    private static string GetCsCleanName(string name)
    {
        if (s_csNameMappings.TryGetValue(name, out string? mappedName))
        {
            return GetCsCleanName(mappedName);
        }
        else if (name.StartsWith("PFN"))
        {
            return "IntPtr";
        }

        return name;
    }

    private static string GetCsTypeName(CppType? type, bool isPointer = false)
    {
        if (type is CppPrimitiveType primitiveType)
        {
            return GetCsTypeName(primitiveType, isPointer);
        }

        if (type is CppQualifiedType qualifiedType)
        {
            return GetCsTypeName(qualifiedType.ElementType, isPointer);
        }

        if (type is CppEnum enumType)
        {
            string enumCsName = GetCsCleanName(enumType.Name);
            if (isPointer)
                return enumCsName + "*";

            return enumCsName;
        }

        if (type is CppTypedef typedef)
        {
            if (typedef.ElementType is CppClass classElementType)
            {
                return GetCsTypeName(classElementType, isPointer);
            }

            string typeDefCsName = GetCsCleanName(typedef.Name);
            if (isPointer)
                return typeDefCsName + "*";

            return typeDefCsName;
        }

        if (type is CppClass @class)
        {
            var className = GetCsCleanName(@class.Name);
            if (isPointer)
                return className + "*";

            return className;
        }

        if (type is CppPointerType pointerType)
        {
            return GetCsTypeName(pointerType);
        }

        if (type is CppArrayType arrayType)
        {
            return GetCsTypeName(arrayType.ElementType, true);
        }

        return string.Empty;
    }

    private static string GetCsTypeName(CppPrimitiveType primitiveType, bool isPointer)
    {
        switch (primitiveType.Kind)
        {
            case CppPrimitiveKind.Void:
                return isPointer ? "nint" : "void";

            case CppPrimitiveKind.Char:
                return isPointer ? "sbyte*" : "sbyte";

            case CppPrimitiveKind.Bool:
                return "bool";

            case CppPrimitiveKind.WChar:
                return isPointer ? "ushort*" : "ushort";

            case CppPrimitiveKind.Short:
                return isPointer ? "short*" : "short";
            case CppPrimitiveKind.Int:
                return isPointer ? "int*" : "int";

            case CppPrimitiveKind.LongLong:
                break;
            case CppPrimitiveKind.UnsignedChar:
                break;
            case CppPrimitiveKind.UnsignedShort:
                return isPointer ? "ushort*" : "ushort";
            case CppPrimitiveKind.UnsignedInt:
                return isPointer ? "uint*" : "uint";

            case CppPrimitiveKind.UnsignedLongLong:
                break;
            case CppPrimitiveKind.Float:
                return isPointer ? "float*" : "float";
            case CppPrimitiveKind.Double:
                return isPointer ? "double*" : "double";
            case CppPrimitiveKind.LongDouble:
                break;


            default:
                return string.Empty;
        }

        return string.Empty;
    }

    private static string GetCsTypeName(CppPointerType pointerType)
    {
        if (pointerType.ElementType is CppQualifiedType qualifiedType)
        {
            if (qualifiedType.ElementType is CppPrimitiveType primitiveType)
            {
                if (primitiveType.Kind == CppPrimitiveKind.Void && qualifiedType.Qualifier == CppTypeQualifier.Const)
                {
                    // const void*
                    return "void*";
                }

                return GetCsTypeName(primitiveType, true);
            }
            else if (qualifiedType.ElementType is CppClass @classType)
            {
                return GetCsTypeName(@classType, true);
            }
            else if (qualifiedType.ElementType is CppPointerType subPointerType)
            {
                return GetCsTypeName(subPointerType, true) + "*";
            }
            else if (qualifiedType.ElementType is CppTypedef typedef)
            {
                return GetCsTypeName(typedef, true);
            }
            else if (qualifiedType.ElementType is CppEnum @enum)
            {
                return GetCsTypeName(@enum, true);
            }

            return GetCsTypeName(qualifiedType.ElementType, true);
        }

        return GetCsTypeName(pointerType.ElementType, true);
    }
}
