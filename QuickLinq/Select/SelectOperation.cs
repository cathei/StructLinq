// QuickLinq, Maxwell Keonwoo Kang <code.athei@gmail.com>, 2022

namespace Cathei.QuickLinq.Select
{
    public class SelectOperation<TIn, TOut> : IQuickOperation
    {
        public MoveNextDelegate<TIteration> GenerateMoveNext<TIteration>()
        {
            // throw new System.NotImplementedException();
        }

        public ResetDelegate<TIteration> GenerateReset<TIteration>()
        {
            // throw new System.NotImplementedException();
        }
    }
}