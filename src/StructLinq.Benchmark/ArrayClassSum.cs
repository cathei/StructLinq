﻿using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;
using StructLinq.Select;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArrayClassSum
    {
        private readonly IEnumerable<int> sysArray;
        public int Count = 1000;
        private readonly Container[] array;
        private readonly ITypedEnumerable<int, SelectEnumerator<Container, int, ArrayStructEnumerator<Container>, ContainerSelect>> safeStructArray;
        private ITypedEnumerable<int, SelectEnumerator<Container, int, ArrayStructEnumerator<Container>, StructFunction<Container, int>>> convertArray;
        private ContainerSelect select;
        public ArrayClassSum()
        {
            array = Enumerable.Range(0, Count).Select(x => new Container(x)).ToArray();
            select = new ContainerSelect();
            sysArray = array.Select(x => x.Element);
            convertArray = array.ToTypedEnumerable().Select(x => x.Element);
            safeStructArray = array.ToTypedEnumerable().Select(ref select, Id<int>.Value);
        }
        [Benchmark]
        public int SysSum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum += array[i].Element;
            }
            return sum;
        }
        [Benchmark(Baseline = true)]
        public int SysEnumerableSum() => sysArray.Sum();

        [Benchmark]
        public int ConvertSum() => convertArray.Sum();

        [Benchmark]
        public int SafeStructSum() => safeStructArray.Sum();
    }


    internal class Container
    {
        public readonly int Element;
        public Container(int element)
        {
            Element = element;
        }
    }


    internal struct ContainerSelect : IFunction<Container, int>
    {
            public int Eval(in Container element)
        {
            return element.Element;
        }
    }

}