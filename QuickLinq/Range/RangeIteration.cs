// QuickLinq, Maxwell Keonwoo Kang <code.athei@gmail.com>, 2022

namespace Cathei.QuickLinq.Range
{
    public struct RangeIteration : IQuickIteration<int>
    {
        internal readonly int start;
        internal readonly int end;

        internal int value;

        public int Current => value;
    }
}