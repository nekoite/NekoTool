using System;

namespace NekoTool.Maths.Utils
{
	public class IntRange : ICloneable, IEquatable<IntRange>
	{
		public int Max { get; }

		public int Min { get; }

		public int Length => Max - Min;

		public IntRange(int min, int max)
		{
			if (max < min)
				throw new ArgumentException("Max is less than min");
			Max = max;
			Min = min;
		}

		public static int RangeMax(params IntRange[] intRanges)
		{
			if (intRanges.Length == 0)
				throw new ArgumentException("No parameter.");
			int max = intRanges[0].Max;
			for (int i = 1; i < intRanges.Length; i++)
			{
				max = Math.Max(intRanges[i].Max, max);
			}

			return max;
		}

		public static int RangeMin(params IntRange[] intRanges)
		{
			if (intRanges.Length == 0)
				throw new ArgumentException("No parameter.");
			int min = intRanges[0].Min;
			for (int i = 1; i < intRanges.Length; i++)
			{
				min = Math.Max(intRanges[i].Min, min);
			}

			return min;
		}

		public static IntRange RangeMinMax(params IntRange[] intRanges)
		{
			return new IntRange(RangeMin(intRanges), RangeMax(intRanges));
		}

		public bool IsSubrange(IntRange other)
		{
			return other.Min >= Min && other.Max <= Max;
		}

		public static bool IsDisjoint(IntRange r1, IntRange r2)
		{
			return r1.Max < r2.Max || r1.Min > r2.Max;
		}

		/// <summary>
		/// Same as Union.
		/// </summary>
		/// <param name="r1"></param>
		/// <param name="r2"></param>
		/// <returns></returns>
		public static IntRange operator +(IntRange r1, IntRange r2)
		{
			if (IsDisjoint(r1, r2))
				throw new ArgumentException("Ranges are disjoint.");
			if (r1.Equals(r2))
				return (IntRange)r1.Clone();
			int min = MathUtil.Min(r1.Min, r2.Min);
			int max = MathUtil.Max(r1.Max, r2.Max);
			return new IntRange(min, max);
		}

		public static IntRange Union(IntRange r1, IntRange r2)
		{
			return r1 + r2;
		}

		public static IntRange Intersect(IntRange r1, IntRange r2)
		{
			if (IsDisjoint(r1, r2))
				throw new ArgumentException("Ranges are disjoint.");
			if (r1.Equals(r2))
				return (IntRange)r1.Clone();
			int min = MathUtil.Max(r1.Min, r2.Min);
			int max = MathUtil.Min(r1.Max, r2.Max);

			return new IntRange(min, max);
		}

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			if (!(obj is IntRange)) return false;

			var o = (IntRange)obj;
			return o.Max == Max && o.Min == Min;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Max * 397) ^ Min;
			}
		}

		public object Clone()
		{
			return new IntRange(Min, Max);
		}

		public bool Equals(IntRange other)
		{
			if (other == null) return false;
			return other.Max == Max && other.Min == Min;
		}

		public override string ToString()
		{
			return $"[{Min}, {Max}]";
		}
	}
}
