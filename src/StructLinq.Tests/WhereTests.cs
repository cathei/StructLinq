﻿using System;
using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class WhereTests
    {
        [Fact]
        public void DelegateTest()
        {
            Func<int, bool> selector = x => x > 0;
            var sys = Enumerable
                .Range(-50, 100)
                .Where(selector)
                .ToArray();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Where(selector)
                .ToArray();
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void StructTest()
        {
            Func<int, bool> selector = x => x>0;
            var sys = Enumerable
                .Range(-50, 100)
                .Where(selector)
                .ToArray();
            var whereFunc = new WhereFunc();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Where(ref whereFunc)
                .ToArray();
            Assert.Equal(sys, structEnum);

        }

        struct WhereFunc : IFunction<int, bool>
        {
            public bool Eval(int element)
            {
                return element > 0;
            }
        }
    }
}