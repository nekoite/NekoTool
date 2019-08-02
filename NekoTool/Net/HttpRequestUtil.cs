using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NekoTool.Net
{
	/// <summary>
	/// Tools for making http requests.
	/// </summary>
	public static class HttpRequestUtil
	{
		public const string DefaultUserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.152 Safari/537";

		public static string Get(string uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				return reader.ReadToEnd();
			}
		}

		public static string Get(string uri, IDictionary<string, string> param)
		{
			return Get(UriUtil.ParseUri(uri, param));
		}

		public static string Get(string uri, object param)
		{
			return Get(UriUtil.ParseUri(uri, param));
		}

		public static async Task<string> GetAsync(string uri, Action<WebHeaderCollection> headers = null)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			headers?.Invoke(request.Headers);
			request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

			using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				return await reader.ReadToEndAsync();
			}
		}

		public static async Task<string> GetAsync(
			string uri,
			IDictionary<string, string> param,
			Action<WebHeaderCollection> headers)
		{
			return await GetAsync(UriUtil.ParseUri(uri, param), headers);
		}

		public static async Task<string> GetAsync(string uri, IDictionary<string, string> headers)
		{
			return await GetAsync(uri, (h) => AddToHeader(h, headers));
		}

		public static string Post(string uri, string data, string contentType, string method = "POST")
		{
			byte[] dataBytes = Encoding.UTF8.GetBytes(data);

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			request.ContentLength = dataBytes.Length;
			request.ContentType = contentType;
			request.Method = method;

			using (Stream requestBody = request.GetRequestStream())
			{
				requestBody.Write(dataBytes, 0, dataBytes.Length);
			}

			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				return reader.ReadToEnd();
			}
		}


		/// <summary>
		/// Async post. Can also be used for other methods (pass into <paramref name="method"/>).
		/// </summary>
		/// <param name="uri"></param>
		/// <param name="data"></param>
		/// <param name="contentType"></param>
		/// <param name="method"></param>
		/// <param name="headers"></param>
		/// <returns></returns>
		public static async Task<string> PostAsync(
			string uri, 
			string data, 
			string contentType, 
			string method = "POST", 
			Action<WebHeaderCollection> headers = null)
		{
			byte[] dataBytes = Encoding.UTF8.GetBytes(data);

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			headers?.Invoke(request.Headers);
			request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			request.ContentLength = dataBytes.Length;
			request.ContentType = contentType;
			request.Method = method;
			request.UserAgent = DefaultUserAgent;

			using (Stream requestBody = request.GetRequestStream())
			{
				await requestBody.WriteAsync(dataBytes, 0, dataBytes.Length);
			}

			using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				return await reader.ReadToEndAsync();
			}
		}

		public static async Task<string> PostAsync(
			string uri,
			string data,
			string contentType,
			string method,
			IDictionary<string, string> headers)
		{
			return await PostAsync(uri, data, contentType, method, (header) =>
			{
				AddToHeader(header, headers);
			});
		}

		public static void AddToHeader(WebHeaderCollection header, IDictionary<string, string> param)
		{
			foreach (var p in param)
			{
				header.Add(p.Key, p.Value);
			}
		}
	}
}
