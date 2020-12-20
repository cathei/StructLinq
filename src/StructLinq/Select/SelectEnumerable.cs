﻿using System;
using System.Runtime.CompilerServices;

namespace StructLinq.Select
{
    public struct SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> : IStructEnumerable<TOut, SelectEnumerator<TIn, TOut, TEnumerator, TFunction>>
        where TFunction : struct, IFunction<TIn, TOut>
        where TEnumerator : struct, IStructEnumerator<TIn>
        where TEnumerable : IStructEnumerable<TIn, TEnumerator>
    {
        #region private fields
        private TFunction function;
        private TEnumerable inner;
        #endregion

        public SelectEnumerable(ref TFunction function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SelectEnumerator<TIn, TOut, TEnumerator, TFunction> GetEnumerator()
        {
            var typedEnumerator = inner.GetEnumerator();
            return new SelectEnumerator<TIn, TOut, TEnumerator, TFunction>(ref function, ref typedEnumerator);
        }
    }
    
    public struct SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator> : IStructEnumerable<TOut, SelectEnumerator<TIn, TOut, TEnumerator>>
        where TEnumerator : struct, IStructEnumerator<TIn>
        where TEnumerable : IStructEnumerable<TIn, TEnumerator>
    {
        #region private fields
        private Func<TIn, TOut> function;
        private TEnumerable inner;
        #endregion

        public SelectEnumerable(Func<TIn, TOut> function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SelectEnumerator<TIn, TOut, TEnumerator> GetEnumerator()
        {
            var typedEnumerator = inner.GetEnumerator();
            return new SelectEnumerator<TIn, TOut, TEnumerator>(function, ref typedEnumerator);
        }
    }
}

    
