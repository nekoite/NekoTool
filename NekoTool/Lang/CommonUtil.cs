using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekoTool.Lang
{
	public static class CommonUtil
	{
		/// <summary>
		/// In seconds.
		/// </summary>
		/// <returns></returns>
		public static long GetUnixTimeStamp()
		{
			return (DateTime.UtcNow.ToUniversalTime().Ticks - 621355968000000000L) / 10000000;
		}

		public static DateTime UnixTimeStampToDateTime(double timestamp)
		{
			DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			dtDateTime = dtDateTime.AddSeconds(timestamp).ToLocalTime();
			return dtDateTime;
		}

		public static T CreateInstance<T>()
		{
			return Activator.CreateInstance<T>();
		}

		public static object CreateInstance(Type t)
		{
			return Activator.CreateInstance(t);
		}

		public static T CreateInstanceOf<T>(T refObj)
		{
			return Activator.CreateInstance<T>();
		}

		public static T CreateInstance<T>(params object[] args)
		{
			return (T) Activator.CreateInstance(typeof(T), args);
		}

		public static T CreateInstanceOf<T>(T refObj, params object[] args)
		{
			return (T) Activator.CreateInstance(typeof(T), args);
		}
	}
}
