﻿
// Generated code

using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static Int16 Min<TEnumerator>(this ITypedEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int16>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
				if (!enumerator.MoveNext())
					throw new ArgumentOutOfRangeException("No elements");
				Int16 result = enumerator.Current;
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current < result)
						result = current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static Int32 Min<TEnumerator>(this ITypedEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int32>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
				if (!enumerator.MoveNext())
					throw new ArgumentOutOfRangeException("No elements");
				Int32 result = enumerator.Current;
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current < result)
						result = current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static Int64 Min<TEnumerator>(this ITypedEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int64>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
				if (!enumerator.MoveNext())
					throw new ArgumentOutOfRangeException("No elements");
				Int64 result = enumerator.Current;
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current < result)
						result = current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt16 Min<TEnumerator>(this ITypedEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt16>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
				if (!enumerator.MoveNext())
					throw new ArgumentOutOfRangeException("No elements");
				UInt16 result = enumerator.Current;
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current < result)
						result = current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt32 Min<TEnumerator>(this ITypedEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt32>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
				if (!enumerator.MoveNext())
					throw new ArgumentOutOfRangeException("No elements");
				UInt32 result = enumerator.Current;
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current < result)
						result = current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt64 Min<TEnumerator>(this ITypedEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt64>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
				if (!enumerator.MoveNext())
					throw new ArgumentOutOfRangeException("No elements");
				UInt64 result = enumerator.Current;
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current < result)
						result = current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static Single Min<TEnumerator>(this ITypedEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Single>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
				if (!enumerator.MoveNext())
					throw new ArgumentOutOfRangeException("No elements");
				Single result = enumerator.Current;
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current < result)
						result = current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static Double Min<TEnumerator>(this ITypedEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Double>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
				if (!enumerator.MoveNext())
					throw new ArgumentOutOfRangeException("No elements");
				Double result = enumerator.Current;
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current < result)
						result = current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static Byte Min<TEnumerator>(this ITypedEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Byte>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
				if (!enumerator.MoveNext())
					throw new ArgumentOutOfRangeException("No elements");
				Byte result = enumerator.Current;
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current < result)
						result = current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static SByte Min<TEnumerator>(this ITypedEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<SByte>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
				if (!enumerator.MoveNext())
					throw new ArgumentOutOfRangeException("No elements");
				SByte result = enumerator.Current;
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current < result)
						result = current;
				}
				return result;
            }
        }
    }


}
