using System;
using System.IO;

namespace NekoTool.IO
{
	/// <summary>
	/// IO工具类，提供流的辅助读取工具
	/// </summary>
	public static class IOUtil
	{
		/// <summary>
		/// 从流中读取一定数量的字节
		/// </summary>
		/// <param name="stream">流</param>
		/// <param name="len">读取字节数量</param>
		/// <returns>数据</returns>
		/// <exception cref="IOException"></exception>
		public static byte[] ReadBytes(this Stream stream, long len)
		{
			byte[] array = new byte[len];
			stream.ReadBytes(array);
			return array;
		}

		/// <summary>
		/// 从流中读取字节至指定缓冲区
		/// </summary>
		/// <param name="stream">流</param>
		/// <param name="buf">缓冲区</param>
		/// <exception cref="IOException"></exception>
		public static void ReadBytes(this Stream stream, byte[] buf)
		{
			int num = 0;
			int num2;
			while ((num2 = stream.Read(buf, num, buf.Length - num)) > 0)
			{
				num += num2;
			}
			if (num != buf.Length)
			{
				throw new IOException(string.Format("Stream did not contain enough bytes ({0}) < ({1})", num, buf.Length));
			}
		}

		public static void ReadBytes(this Stream stream, byte[] buffer, int offset, int count)
		{
			if (offset + count > buffer.Length)
				throw new ArgumentException();
			var read = 0;
			while (read < count)
			{
				var available = stream.Read(buffer, offset, count - read);
				if (available == 0)
				{
					throw new ObjectDisposedException(null);
				}

				read += available;
				offset += available;
			}
		}
	}
}
