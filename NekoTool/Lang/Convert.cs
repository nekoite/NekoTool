
using System;

namespace NekoTool.Lang
{
	public static class Convert
	{
		/// <summary>
		/// Convert <see cref="string"/> to <see cref="int"/>, if failed return default value <paramref name="default"/>
		/// </summary>
		/// <param name="s"></param>
		/// <param name="default"></param>
		/// <returns></returns>
		public static int Atoi(string s, int @default = 0)
		{
			if (int.TryParse(s, out int i))
			{
				return i;
			}

			return @default;
		}

		/// <summary>
		/// Convert a <see cref="string"/> representing seconds to <see cref="TimeSpan"/>, if failed return <see cref="TimeSpan.Zero"/>.
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static TimeSpan StrToTimeSpan(string s)
		{
			if (int.TryParse(s, out int i))
			{
				return TimeSpan.FromSeconds((double)i);
			}

			return TimeSpan.Zero;
		}

		/// <summary>
		/// Reduces a byte array to an int array (by default endian).
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static int[] Reduce(byte[] arr)
		{
			if (arr.Length % 4 != 0)
				throw new ArgumentException("Array length not divisible by 4");
			var size = arr.Length / sizeof(int);
			var ints = new int[size];
			for (var index = 0; index < size; index++)
			{
				ints[index] = BitConverter.ToInt32(arr, index * sizeof(int));
			}

			return ints;
		}

		public static int[] Reduce(byte[] arr, int start, int length)
		{
			if (length % 4 != 0)
				throw new ArgumentException("Length not divisible by 4", nameof(length));
			if (start + length > arr.Length)
				throw new ArgumentException("Length too big", nameof(length));
			var size = length / sizeof(int);
			var ints = new int[size];
			for (int i = 0; i < size; i++)
			{
				ints[i] = BitConverter.ToInt32(arr, start + i * sizeof(int));
			}

			return ints;
		}
	}
}
