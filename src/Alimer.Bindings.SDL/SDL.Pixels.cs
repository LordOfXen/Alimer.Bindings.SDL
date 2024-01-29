﻿// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Runtime.InteropServices;
using static SDL.SDL;
using static SDL.SDL_bool;

namespace SDL;

unsafe partial class SDL
{
    public static uint SDL_DEFINE_PIXELFOURCC(byte A, byte B, byte C, byte D) => SDL_FOURCC(A, B, C, D);

    public static uint SDL_DEFINE_PIXELFORMAT(
            SDL_PixelType type,
            uint order,
            SDL_PackedLayout layout,
            byte bits,
            byte bytes
        )
    {
        return (uint)(
            (1 << 28) |
            (((byte)type) << 24) |
            (((byte)order) << 20) |
            (((byte)layout) << 16) |
            (bits << 8) |
            (bytes)
        );
    }

    public static byte SDL_PIXELFLAG(uint X)
    {
        return (byte)((X >> 28) & 0x0F);
    }

    public static SDL_PixelType SDL_PIXELTYPE(SDL_PixelFormatEnum X)
    {
        return (SDL_PixelType)(((uint)X >> 24) & 0x0F);
    }

    public static SDL_PackedOrder SDL_PIXELORDER(SDL_PixelFormatEnum X)
    {
        return (SDL_PackedOrder)(((uint)X >> 20) & 0x0F);
    }

    public static SDL_PackedLayout SDL_PIXELLAYOUT(SDL_PixelFormatEnum X)
    {
        return (SDL_PackedLayout)(((uint)X >> 16) & 0x0F);
    }

    public static byte SDL_BITSPERPIXEL(uint X)
    {
        return (byte)((X >> 8) & 0xFF);
    }

    public static byte SDL_BYTESPERPIXEL(SDL_PixelFormatEnum X)
    {
        if (SDL_ISPIXELFORMAT_FOURCC(X))
        {
            if ((X == SDL_PixelFormatEnum.Yuy2) || (X == SDL_PixelFormatEnum.Uyvy) || (X == SDL_PixelFormatEnum.Yvyu))
            {
                return 2;
            }
            return 1;
        }
        return (byte)((uint)X & 0xFF);
    }

    public static bool SDL_ISPIXELFORMAT_INDEXED(SDL_PixelFormatEnum format)
    {
        if (SDL_ISPIXELFORMAT_FOURCC(format))
        {
            return false;
        }
        SDL_PixelType pType = SDL_PIXELTYPE(format);
        return (
            pType == SDL_PixelType.Index1 ||
            pType == SDL_PixelType.Index4 ||
            pType == SDL_PixelType.Index8
        );
    }

    public static bool SDL_ISPIXELFORMAT_PACKED(SDL_PixelFormatEnum format)
    {
        if (SDL_ISPIXELFORMAT_FOURCC(format))
        {
            return false;
        }
        SDL_PixelType pType = SDL_PIXELTYPE(format);
        return (
            pType == SDL_PixelType.Packed8 ||
            pType == SDL_PixelType.Packed16 ||
            pType == SDL_PixelType.Packed32
        );
    }

    public static bool SDL_ISPIXELFORMAT_ARRAY(SDL_PixelFormatEnum format)
    {
        if (SDL_ISPIXELFORMAT_FOURCC(format))
        {
            return false;
        }

        SDL_PixelType pType = SDL_PIXELTYPE(format);
        return (
            pType == SDL_PixelType.ArrayU8 ||
            pType == SDL_PixelType.ArrayU16 ||
            pType == SDL_PixelType.ArrayU32 ||
            pType == SDL_PixelType.ArrayF16 ||
            pType == SDL_PixelType.ArrayF32
        );
    }

    public static bool SDL_ISPIXELFORMAT_ALPHA(SDL_PixelFormatEnum format)
    {
        if (!SDL_ISPIXELFORMAT_PACKED(format))
            return false;

        SDL_PackedOrder pOrder = SDL_PIXELORDER(format);
        return (
            pOrder == SDL_PackedOrder.Argb ||
            pOrder == SDL_PackedOrder.Rgba ||
            pOrder == SDL_PackedOrder.Abgr ||
            pOrder == SDL_PackedOrder.Bgra
        );
    }

    public static bool SDL_ISPIXELFORMAT_10BIT(SDL_PixelFormatEnum format)
    {
        if (SDL_PIXELTYPE(format) == SDL_PixelType.Packed32 && SDL_PIXELLAYOUT(format) == SDL_PackedLayout._2101010)
            return true;

        return false;
    }

    public static bool SDL_ISPIXELFORMAT_FOURCC(SDL_PixelFormatEnum format)
    {
        return (format == SDL_PixelFormatEnum.Unknown) && (SDL_PIXELFLAG((uint)format) != 1);
    }
    public static string SDL_GetPixelFormatName(SDL_PixelFormatEnum format)
    {
        return GetStringOrEmpty(SDL_GetPixelFormatName((uint)format));
    }
    public static SDL_PixelFormat* SDL_CreatePixelFormat(SDL_PixelFormatEnum format)
    {
        return SDL_CreatePixelFormat((uint)format);
    }

    public static SDL_Surface* SDL_CreateSurface(int width, int height, SDL_PixelFormatEnum format)
    {
        return SDL_CreateSurface(width, height, (uint)format);
    }

    [LibraryImport(LibName, EntryPoint = "SDL_CreateSurfaceFrom")]
    public static partial SDL_Surface* SDL_CreateSurfaceFrom(void* pixels, int width, int height, int pitch, uint format);

    public static SDL_Surface* SDL_CreateSurfaceFrom(nint pixels, int width, int height, int pitch, SDL_PixelFormatEnum format)
    {
        return SDL_CreateSurfaceFrom(pixels, width, height, pitch, (uint)format);
    }

    public static SDL_Surface* SDL_CreateSurfaceFrom<T>(T[] source, int width, int height, int pitch, SDL_PixelFormatEnum format)
        where T : unmanaged
    {
        ReadOnlySpan<T> span = source.AsSpan();

        return SDL_CreateSurfaceFrom(span, width, height, pitch, format);
    }

    public static SDL_Surface* SDL_CreateSurfaceFrom<T>(ReadOnlySpan<T> source, int width, int height, int pitch, SDL_PixelFormatEnum format)
        where T : unmanaged
    {
        return SDL_CreateSurfaceFrom(ref MemoryMarshal.GetReference(source), width, height, pitch, format);
    }

    public static SDL_Surface* SDL_CreateSurfaceFrom<T>(ref T source, int width, int height, int pitch, SDL_PixelFormatEnum format)
         where T : unmanaged
    {
        fixed (void* sourcePointer = &source)
        {
            return SDL_CreateSurfaceFrom(sourcePointer, width, height, pitch, (uint)format);
        }
    }
}