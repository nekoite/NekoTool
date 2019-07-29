using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekoTool.Lang.Str
{
	public static class EncodingUtil
	{
		public static byte[] GetEncodedBytes(string s, string encoding)
		{
			return Encoding.GetEncoding(encoding).GetBytes(s);
		}
	}
}
