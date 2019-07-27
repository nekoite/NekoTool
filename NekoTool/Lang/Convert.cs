
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
		/// C++ style reinterpret cast.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="o"></param>
		/// <returns></returns>
		public static T reinterpret_cast<T>(this object o)
		{
			return (T) o;
		}

		/// <summary>
		/// C++ style static cast. Basically same as <see cref="reinterpret_cast{T}"/>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="o"></param>
		/// <returns></returns>
		public static T static_cast<T>(this object o)
		{
			return (T) System.Convert.ChangeType(o, typeof(T));
		}

		/// <summary>
		/// Same as <see cref="System.Convert.ChangeType(object, Type)"/>
		/// </summary>
		/// <param name="o"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		public static object ChangeType(this object o, Type type)
		{
			return System.Convert.ChangeType(o, type);
		}
	}
}
