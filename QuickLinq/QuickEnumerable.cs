// QuickLinq, Maxwell Keonwoo Kang <code.athei@gmail.com>, 2022

using System;
using System.Collections;
using System.Collections.Generic;

namespace Cathei.QuickLinq
{
    public readonly struct QuickEnumerable<T, TSource, TIteration> // : IEnumerable<T>
        where TSource : struct
        where TIteration : struct, IQuickOperation<TSource, TIteration>, IQuickIteration<T, TSource>
    {
        private readonly TSource source;

        public QuickEnumerable(TSource source)
        {
            this.source = source;
        }

        public QuickEnumerator<T, TSource, TIteration> GetEnumerator()
        {
            return new QuickEnumerator<T, TSource, TIteration>(source);
        }

        // IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();
    }

}