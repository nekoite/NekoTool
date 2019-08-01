using System.Text;
using NekoTool.Lang.Reflection;

namespace NekoTool.Lang.Str
{
	public static class EncodingUtil
	{
		public static byte[] GetEncodedBytes(string s, string encoding)
		{
			return Encoding.GetEncoding(encoding).GetBytes(s);
		}

		public static byte[] GetEncodedBytes(string s, CodePage cp)
		{
			return GetEncoding(cp).GetBytes(s);
		}

		public static Encoding GetEncoding(CodePage cp)
		{
			return Encoding.GetEncoding((int) cp);
		}

		public static string GetEncodingName(CodePage cp)
		{
			return AttributeUtil.GetAttributeValue(cp.GetType(), cp.ToString(),
				(EncodingNameAttribute ena) => ena.EncodingName);
		}
	}
}
