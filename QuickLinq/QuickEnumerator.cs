// QuickLinq, Maxwell Keonwoo Kang <code.athei@gmail.com>, 2022

using System;
using System.Collections;
using System.Collections.Generic;

namespace Cathei.QuickLinq
{
    public struct QuickEnumerator<T, TOperation, TIteration> // : IEnumerator<T>
        where TOperation : IQuickOperation, new()
        where TIteration : IQuickIteration<T>
    {
        private TIteration iteration;

        public T Current => iteration.Current;

        // object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            return QuickOperation<T, TOperation, TIteration>.MoveNext(ref iteration);
        }

        public void Reset()
        {
            QuickOperation<T, TOperation, TIteration>.Reset(ref iteration);
        }

        // I heard implementing Dispose will prevent inlining of foreach?
        // public void Dispose()
        // {
        //
        // }
    }
}