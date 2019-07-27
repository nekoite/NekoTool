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
			sb.Append($"({typeof(K)}, {typeof(V)})[\n");
			foreach (var key in dict.Keys)
			{
				sb.Append("{");
				sb.Append(key);
				sb.Append(", ");
				sb.Append(dict[key]);
				sb.Append("},\n");
			}

			sb.Remove(sb.Length - 2, 2);
			sb.Append("\n]");
			return sb.ToString();
		}

		/// <summary>
		/// Total byte count to readable byte count with suffixes.
		/// </summary>
		/// <param name="bytes"></param>
		/// <param name="si"></param>
		/// <param name="digits"></param>
		/// <returns></returns>
		public static string GetHumanReadableByteCount(long bytes, bool si = true, int digits = 1)
		{
			int unit = si ? 1000 : 1024;
			if (bytes < unit) return bytes + " B";
			int exp = (int)(Math.Log(bytes) / Math.Log(unit));
			String pre = (si ? "kMGTPE" : "KMGTPE")[exp - 1] + (si ? "" : "i");
			return string.Format("{0:F" + digits + "} {1}B", bytes / Math.Pow(unit, exp), pre);
		}
	}
}
