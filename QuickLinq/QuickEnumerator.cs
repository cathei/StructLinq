// QuickLinq, Maxwell Keonwoo Kang <code.athei@gmail.com>, 2022

using System;
using System.Collections;
using System.Collections.Generic;

namespace Cathei.QuickLinq
{
    public struct QuickEnumerator<T, TSource, TIteration> // : IEnumerator<T>
        where TSource : struct
        where TIteration : struct, IQuickOperation<TSource, TIteration>, IQuickIteration<T, TSource>
    {
        private TIteration iteration;

        public QuickEnumerator(in TSource source)
        {
            iteration = QuickOperation<T, TSource, TIteration>.Create(source);
        }

        public T Current => iteration.Current;

        // object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            return QuickOperation<T, TSource, TIteration>.MoveNext(ref iteration);
        }

        public void Reset()
        {
            QuickOperation<T, TSource, TIteration>.Reset(ref iteration);
        }

        // I heard implementing Dispose will prevent inlining of foreach?
        // public void Dispose()
        // {
        //
        // }
    }
}