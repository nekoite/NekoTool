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
	}
}
