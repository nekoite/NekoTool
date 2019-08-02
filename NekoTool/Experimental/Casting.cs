using System;

namespace NekoTool.Experimental
{
	public static class Casting
	{
		/// <summary>
		/// C++ style reinterpret cast.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="o"></param>
		/// <returns></returns>
		public static T reinterpret_cast<T>(this object o)
		{
			return (T)o;
		}

		/// <summary>
		/// C++ style static cast. Basically same as <see cref="reinterpret_cast{T}"/>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="o"></param>
		/// <returns></returns>
		public static T static_cast<T>(this object o)
		{
			return (T)System.Convert.ChangeType(o, typeof(T));
		}

		/// <summary>
		/// Same as <see cref="System.Convert.ChangeType(object, Type)"/>
		/// </summary>
		/// <param name="o"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		public static object ChangeType(this object o, Type type)
		{
			return Convert.ChangeType(o, type);
		}
	}
}
