﻿using System.Runtime.CompilerServices;

namespace StructLinq.Select
{
    public struct RefSelectCollection<TIn, TOut, TEnumerable, TEnumerator, TFunction> : IStructCollection<TOut, RefSelectEnumerator<TIn, TOut, TEnumerator, TFunction>>
        where TFunction : struct, IInFunction<TIn, TOut>
        where TEnumerator : struct, IRefStructEnumerator<TIn>
        where TEnumerable : IRefStructCollection<TIn, TEnumerator>
    {
        #region private fields
        private TFunction function;
        private TEnumerable inner;
        #endregion

        public RefSelectCollection(ref TFunction function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefSelectEnumerator<TIn, TOut, TEnumerator, TFunction> GetEnumerator()
        {
            var typedEnumerator = inner.GetEnumerator();
            return new RefSelectEnumerator<TIn, TOut, TEnumerator, TFunction>(ref function, ref typedEnumerator);
        }

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => inner.Count;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            inner.Slice(start, length);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public object Clone()
        {
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut Get(int i)
        {
            return function.Eval(inner.Get(i));
        }

    }
}