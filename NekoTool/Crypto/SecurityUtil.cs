using System;
using System.Security.Cryptography;
using System.Text;
using NekoTool.Lang.Str;

namespace NekoTool.Crypto
{
	public static class SecurityUtil
	{
		public static string GetMD5(string data)
		{
			return GetMD5(data, Encoding.UTF8);
		}

		public static string GetMD5(string data, Encoding encoding)
		{
			using (MD5 md5 = MD5.Create())
			{
				var d = encoding.GetBytes(data);
				var hashBytes = md5.ComputeHash(d);
				return StringGetter.GetHexString(hashBytes);
			}
		}

		public static string GetSHA1(string data)
		{
			return GetSHA1(data, Encoding.UTF8);
		}

		public static string GetSHA1(string data, Encoding encoding)
		{
			using (SHA1 sha1 = SHA1.Create())
			{
				var hash = sha1.ComputeHash(encoding.GetBytes(data));
				return StringGetter.GetHexString(hash);
			}
		}
	}
}
