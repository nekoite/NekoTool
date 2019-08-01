using System.Text;
using NekoTool.Lang.Reflection;

namespace NekoTool.Lang.Str
{
	public static class EncodingUtil
	{
		/// <summary>
		/// Gets the encoded bytes of a string using the encoding.
		/// To look up the encoding name, use <see cref="GetEncodingName"/>.
		/// </summary>
		/// <param name="s"></param>
		/// <param name="encoding">The encoding by string</param>
		/// <returns></returns>
		public static byte[] GetEncodedBytes(string s, string encoding)
		{
			return Encoding.GetEncoding(encoding).GetBytes(s);
		}

		/// <summary>
		/// Gets the encoded bytes of a string using the encoding given.
		/// </summary>
		/// <param name="s"></param>
		/// <param name="cp"></param>
		/// <returns></returns>
		public static byte[] GetEncodedBytes(string s, CodePage cp)
		{
			return GetEncoding(cp).GetBytes(s);
		}

		/// <summary>
		/// Gets the encoding using a <see cref="CodePage"/>.
		/// </summary>
		/// <param name="cp"></param>
		/// <returns></returns>
		public static Encoding GetEncoding(CodePage cp)
		{
			return Encoding.GetEncoding((int) cp);
		}

		/// <summary>
		/// Gets the <see cref="EncodingNameAttribute.EncodingName"/> of the specific <see cref="CodePage"/>.
		/// </summary>
		/// <param name="cp"></param>
		/// <returns></returns>
		public static string GetEncodingName(CodePage cp)
		{
			return AttributeUtil.GetAttributeValue(cp.GetType(), cp.ToString(),
				(EncodingNameAttribute ena) => ena.EncodingName);
		}
	}
}
