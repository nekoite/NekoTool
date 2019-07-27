using System;

namespace NekoTool.Maths.Utils
{
	public static class MathUtil
	{
		private static Random random = null;

		public static T Max<T>(params T[] arr) where T : IComparable<T>
		{
			if (arr.Length == 0)
				throw new ArgumentException("Length 0 array");
			T max = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i].CompareTo(max) > 0)
				{
					max = arr[i];
				}
			}

			return max;
		}

		public static T Min<T>(params T[] arr) where T : IComparable<T>
		{
			if (arr.Length == 0)
				throw new ArgumentException("Length 0 array");
			T min = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i].CompareTo(min) < 0)
				{
					min = arr[i];
				}
			}

			return min;
		}

		/// <summary>
		/// Not inclusive.
		/// </summary>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int NextInt(int max)
		{
			if (random == null)
			{
				random = new Random();
			}

			return random.Next(max);
		}

		public static int NextInt(int min, int max)
		{
			if (random == null)
			{
				random = new Random();
			}

			return random.Next(min, max);
		}

		/// <summary>
		/// Includes every.
		/// </summary>
		/// <param name="intRange"></param>
		/// <returns></returns>
		public static int NextInt(IntRange intRange)
		{
			return NextInt(intRange.Min, intRange.Max + 1);
		}
	}
}
