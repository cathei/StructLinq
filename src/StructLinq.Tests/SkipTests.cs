﻿using System.Linq;
using StructLinq.Range;
using StructLinq.Skip;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class SkipTests : AbstractEnumerableTests<int,
        SkipEnumerable<int, WhereEnumerable<int, RangeEnumerable, RangeEnumerator, StructFunction<int, bool>>, WhereEnumerator<int, RangeEnumerator, StructFunction<int, bool>>>,
        SkipEnumerator<int, WhereEnumerator<int, RangeEnumerator, StructFunction<int, bool>>>>
    {

        protected override SkipEnumerable<int, WhereEnumerable<int, RangeEnumerable, RangeEnumerator, StructFunction<int, bool>>, WhereEnumerator<int, RangeEnumerator, StructFunction<int, bool>>> Build(int size)
        {
            SkipEnumerable<int, WhereEnumerable<int, RangeEnumerable, RangeEnumerator, StructFunction<int, bool>>, WhereEnumerator<int, RangeEnumerator, StructFunction<int, bool>>> skipEnumerable = StructEnumerable.Range(-1, size + 5).Where(x=>true, x=>x).Skip(5, x=> x);
            return skipEnumerable;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeTheSameAsSystem(uint skipCount)
        {
            var expected = Enumerable.Range(0, 7).ToArray().Skip((int)skipCount).ToArray();
            var value = Enumerable.Range(0, 7).ToArray().ToStructEnumerable().Where(x=> true).Skip(skipCount).ToArray();

            Assert.Equal(expected, value);
        }
    }
}
