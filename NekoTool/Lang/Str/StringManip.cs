using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NekoTool.Lang.Str
{
	public static class StringManip
	{
		/// <summary>
		/// Returns a list. Split by whitespaces in all strings in original list.
		/// </summary>
		/// <param name="strList"></param>
		/// <returns></returns>
		public static IEnumerable<string> SplitAllWhitespace(IEnumerable<string> strList)
		{
			var copy = new List<string>();
			foreach (var s in strList)
			{
				string[] ss = s.Split(new [] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (var p in ss)
				{
					if (!string.IsNullOrWhiteSpace(p))
					{
						copy.Add(p);
					}
				}
			}
			return copy;
		}

		/// <summary>
		/// Split a string by a regex (java style).
		/// </summary>
		/// <param name="s"></param>
		/// <param name="regex"></param>
		/// <returns></returns>
		public static string[] Split(this string s, string regex)
		{
			return Regex.Split(s, regex);
		}
	}
}
