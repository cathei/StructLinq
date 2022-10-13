// QuickLinq, Maxwell Keonwoo Kang <code.athei@gmail.com>, 2022

using System;
using System.Collections;
using System.Collections.Generic;

namespace Cathei.QuickLinq
{
    public struct QuickEnumerable<T, TOperation, TIteration> // : IEnumerable<T>
        where TOperation : IQuickOperation, new()
        where TIteration : IQuickIteration<T>
    {
        public QuickEnumerator<T, TOperation, TIteration> GetEnumerator()
        {
            return new QuickEnumerator<T, TOperation, TIteration>();
        }

        // IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();
    }

}