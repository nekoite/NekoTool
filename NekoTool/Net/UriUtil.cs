using System.Collections.Generic;
using System.Linq;

namespace NekoTool.Net
{
	public static class UriUtil
	{
		/// <summary>
		/// Parse a query anonymous object to a valid query string (key-value pair)
		/// Format is like a=1&amp;b=2&amp;...
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static string ParseQueryString(object obj)
		{
			return string.Join("&", obj.GetType().GetProperties().Select(x => string.Format("{0}={1}", x.Name, x.GetValue(obj))));
		}

		public static string ParseUri(string uri, IDictionary<string, string> param)
		{
			return uri + "?" + string.Join("&", param.Select((k, v) => $"{k}={v}"));
		}

		public static string ParseUri(string uri, object param)
		{
			return uri + "?" + ParseQueryString(param);
		}
	}
}
