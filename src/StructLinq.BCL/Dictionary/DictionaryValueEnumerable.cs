﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.BCL.Dictionary
{
    public struct DictionaryValueEnumerable<TKey, TValue> : IStructCollection<TValue, DictionaryValueEnumerator<TKey, TValue>>
    {
        private readonly Dictionary<TKey, TValue> dictionary;
        private readonly DictionaryLayout<TKey, TValue> dictionaryLayout;
        private int count;
        private int start;

        internal DictionaryValueEnumerable(Dictionary<TKey, TValue> dictionary, int start, int count)
        {
            this.dictionary = dictionary;
            dictionaryLayout = Unsafe.As<Dictionary<TKey, TValue>, DictionaryLayout<TKey, TValue>>(ref dictionary);
            this.start = start;
            this.count = count;
        }

        public DictionaryValueEnumerable(Dictionary<TKey, TValue> dictionary) :
            this(dictionary, 0, Int32.MaxValue)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly DictionaryValueEnumerator<TKey, TValue> GetEnumerator()
        {
            return new DictionaryValueEnumerator<TKey, TValue>(dictionaryLayout.Entries, start, Count);
        }

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => MathHelpers.Min(dictionary.Count, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint length)
        {
            this.start = (int)start + this.start;
            this.count = (int)length + this.start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public object Clone()
        {
            return new DictionaryValueEnumerable<TKey, TValue>(dictionary, start, count);
        }

    }
}
