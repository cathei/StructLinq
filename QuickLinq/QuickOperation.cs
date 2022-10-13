// QuickLinq, Maxwell Keonwoo Kang <code.athei@gmail.com>, 2022

using System;

namespace Cathei.QuickLinq
{
    public delegate bool MoveNextDelegate<TIteration>(ref TIteration iteration);
    public delegate void ResetDelegate<TIteration>(ref TIteration iteration);

    public interface IQuickOperation
    {
        MoveNextDelegate<TIteration> GenerateMoveNext<TIteration>();
        ResetDelegate<TIteration> GenerateReset<TIteration>();
    }

    internal static class QuickOperation<TOperation>
        where TOperation : IQuickOperation, new()
    {
        public static readonly TOperation Instance;

        static QuickOperation()
        {
            Instance = new TOperation();
        }
    }

    internal static class QuickOperation<T, TOperation, TIteration>
        where TOperation : IQuickOperation, new()
        where TIteration : IQuickIteration<T>
    {
        static QuickOperation()
        {
            MoveNext = QuickOperation<TOperation>.Instance.GenerateMoveNext<TIteration>();
            Reset = QuickOperation<TOperation>.Instance.GenerateReset<TIteration>();
        }

        public static readonly MoveNextDelegate<TIteration> MoveNext;
        public static readonly ResetDelegate<TIteration> Reset;

        //
        //
        // public static bool MoveNext(ref TIteration iteration)
        // {
        //
        // }
        //
        // public static void Reset(ref TIteration iteration)
        // {
        //
        // }
    }
}