using System;
using System.Runtime.CompilerServices;

namespace StructLinq
{
    public struct StructWrap<T, TEnumerable, TEnumerator> : IStructEnumerable<T, TEnumerator>
        where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        private TEnumerable enumerable;

        public StructWrap(in TEnumerable enumerable)
        {
            this.enumerable = enumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor) where TVisitor : IVisitor<T>
        {
            return enumerable.Visit(ref visitor);
        }
    }
}