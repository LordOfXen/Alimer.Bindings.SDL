﻿// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace SDL;

public readonly partial struct SDL_CameraDeviceID(uint value) : IComparable, IComparable<SDL_CameraDeviceID>, IEquatable<SDL_CameraDeviceID>, IFormattable
{
    public readonly uint Value = value;

    public static bool operator ==(SDL_CameraDeviceID left, SDL_CameraDeviceID right) => left.Value == right.Value;

    public static bool operator !=(SDL_CameraDeviceID left, SDL_CameraDeviceID right) => left.Value != right.Value;

    public static bool operator <(SDL_CameraDeviceID left, SDL_CameraDeviceID right) => left.Value < right.Value;

    public static bool operator <=(SDL_CameraDeviceID left, SDL_CameraDeviceID right) => left.Value <= right.Value;

    public static bool operator >(SDL_CameraDeviceID left, SDL_CameraDeviceID right) => left.Value > right.Value;

    public static bool operator >=(SDL_CameraDeviceID left, SDL_CameraDeviceID right) => left.Value >= right.Value;

    public static implicit operator uint(SDL_CameraDeviceID value) => value.Value;

    public static implicit operator SDL_CameraDeviceID(uint value) => new (value);

    public int CompareTo(object? obj)
    {
        if (obj is SDL_CameraDeviceID other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException($"obj is not an instance of {nameof(SDL_CameraDeviceID)}.");
    }

    public int CompareTo(SDL_CameraDeviceID other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is SDL_CameraDeviceID other) && Equals(other);

    public bool Equals(SDL_CameraDeviceID other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
