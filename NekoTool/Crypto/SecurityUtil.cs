using System;
using System.Security.Cryptography;
using System.Text;
using NekoTool.Lang.Str;

namespace NekoTool.Crypto
{
	public static class SecurityUtil
	{
		/// <summary>
		/// Gets the string representation of MD5
		/// of a string data using UTF8 encoding.
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static string GetMD5(string data)
		{
			return GetMD5(data, Encoding.UTF8);
		}

		/// <summary>
		/// Gets the string representation of MD5 of a byte data array.
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static string GetMD5(byte[] data)
		{
			using (MD5 md5 = MD5.Create())
			{
				return StringGetter.GetHexString(md5.ComputeHash(data));
			}
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

		/// <summary>
		/// Gets the string representation of SHA1
		/// of a string data using UTF8 encoding.
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static string GetSHA1(string data)
		{
			return GetSHA1(data, Encoding.UTF8);
		}

		/// <summary>
		/// Gets the string representation of SHA1 of a byte data array.
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static string GetSHA1(byte[] data)
		{
			using (SHA1 sha1 = SHA1.Create())
			{
				return StringGetter.GetHexString(sha1.ComputeHash(data));
			}
		}

		/// <summary>
		/// Gets the string representation of SHA1
		/// of a string data using a specific encoding.
		/// </summary>
		/// <param name="data"></param>
		/// <param name="encoding"></param>
		/// <returns></returns>
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
