﻿
using System;
using System.Runtime.CompilerServices;
using StructLinq.SkipWhile;
using StructLinq.TakeWhile;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefTakeWhileEnumerable<T, TFunction, TEnumerable, TEnumerator> TakeWhile<T, TFunction, TEnumerable, TEnumerator>(this TEnumerable enumerable, TFunction predicate,
                                                                                                                                    Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TFunction : struct, IInFunction<T, bool>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            return new(enumerable, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefTakeWhileEnumerable<T, StructInFunction<T, bool>, TEnumerable, TEnumerator> TakeWhile<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, InFunc<T, bool> predicate,
                                                                                                                                            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            return new(enumerable, predicate.ToStruct());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefTakeWhileEnumerable<T, StructInFunction<T, bool>, IRefStructEnumerable<T, TEnumerator>, TEnumerator> TakeWhile<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return new(enumerable, predicate.ToStruct());
        }

    }
}
