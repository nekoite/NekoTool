using System;
using System.Runtime.InteropServices.ComTypes;

namespace NekoTool.Experimental
{
	public static class Functional
	{
		/// <summary>
		/// Reduces a function by one argument
		/// </summary>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="TR"></typeparam>
		/// <param name="f"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		static TR _<T1, TR>(this Func<T1, TR> f, T1 val)
		{
			return f(val);
		}

		/// <summary>
		/// Reduces a function by one argument
		/// </summary>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <typeparam name="TR"></typeparam>
		/// <param name="f"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		static Func<T2, TR> _<T1, T2, TR>(this Func<T1, T2, TR> f, T1 val)
		{
			return (t2) => f(val, t2);
		}

		/// <summary>
		/// Reduces a function by one argument
		/// </summary>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <typeparam name="T3"></typeparam>
		/// <typeparam name="TR"></typeparam>
		/// <param name="f"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		static Func<T2, T3, TR> _<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> f, T1 val)
		{
			return (t2, t3) => f(val, t2, t3);
		}
	}
}
