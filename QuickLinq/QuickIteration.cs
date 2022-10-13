// QuickLinq, Maxwell Keonwoo Kang <code.athei@gmail.com>, 2022

using System;

namespace Cathei.QuickLinq
{
    public interface IQuickIteration<out T>
    {
        public T Current { get; }
    }
}