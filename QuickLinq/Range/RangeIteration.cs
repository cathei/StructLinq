// QuickLinq, Maxwell Keonwoo Kang <code.athei@gmail.com>, 2022

namespace Cathei.QuickLinq.Range
{
    public struct RangeIteration : IQuickOperation<RangeSource, RangeIteration>, IQuickIteration<int, RangeSource>
    {
        private readonly RangeSource source;
        private int value;

        public int Current => value;

        private RangeIteration(in RangeSource source)
        {
            this.source = source;
            value = source.start - 1;
        }

        private static RangeIteration Create(in RangeSource source)
        {
            return new RangeIteration(source);
        }

        private bool MoveNext(ref RangeIteration iteration)
        {
            return ++iteration.value < iteration.source.end;
        }

        private static void Reset(ref RangeIteration iteration)
        {
            iteration.value = iteration.source.start - 1;
        }

        IQuickOperation<RangeSource, RangeIteration>.CreateDelegate IQuickOperation<RangeSource, RangeIteration>.
            CreateMethod => Create;

        IQuickOperation<RangeSource, RangeIteration>.MoveNextDelegate IQuickOperation<RangeSource, RangeIteration>.
            MoveNextMethod => MoveNext;

        IQuickOperation<RangeSource, RangeIteration>.ResetDelegate IQuickOperation<RangeSource, RangeIteration>.
            ResetMethod => Reset;
    }
}