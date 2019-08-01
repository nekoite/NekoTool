using System;
using System.Collections.Generic;
using System.Text;

namespace NekoTool.Lang.Str
{
	public static class StringGetter
	{
		public static string GetString<T>(this IEnumerable<T> list)
		{
			var sb = new StringBuilder();
			sb.Append(typeof(T));
			sb.Append('[');
			foreach (var item in list)
			{
				sb.Append(item);
				sb.Append(", ");
			}

			sb.Remove(sb.Length - 2, 2);
			sb.Append(']');
			return sb.ToString();
		}

		public static string GetString<K, V>(this IDictionary<K, V> dict)
		{
			var sb = new StringBuilder();
			sb.Append($"({typeof(K)}, {typeof(V)})[ ");
			foreach (var key in dict.Keys)
			{
				sb.Append("{");
				sb.Append(key);
				sb.Append(", ");
				sb.Append(dict[key]);
				sb.Append("}, ");
			}

			sb.Remove(sb.Length - 2, 2);
			sb.Append(" ]");
			return sb.ToString();
		}

		/// <summary>
		/// Total byte count to readable byte count with suffixes.
		/// </summary>
		/// <param name="bytes"></param>
		/// <param name="si"></param>
		/// <param name="digits"></param>
		/// <returns></returns>
		public static string GetHumanReadableByteCount(long bytes, bool si = false, int digits = 1)
		{
			int unit = si ? 1000 : 1024;
			if (bytes < unit) return bytes + " B";
			int exp = (int)(Math.Log(bytes) / Math.Log(unit));
			String pre = (si ? "kMGTPE" : "KMGTPE")[exp - 1] + (si ? "" : "i");
			return string.Format("{0:F" + digits + "} {1}B", bytes / Math.Pow(unit, exp), pre);
		}

		/// <summary>
		/// Gets the hex representation of a byte array without separator and all uppercase.
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static string GetHexString(byte[] arr)
		{
			var sb = new StringBuilder();
			for (int i = 0; i < arr.Length; i++)
			{
				sb.Append(arr[i].ToString("X2"));
			}
			return sb.ToString();
		}

		/// <summary>
		/// Gets the hex representation of a byte array with the specific separator and all upper case.
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="separator"></param>
		/// <returns></returns>
		public static string GetHexString(byte[] arr, string separator)
		{
			return BitConverter.ToString(arr).ToUpper().Replace("-", separator);
		}
	}
}
