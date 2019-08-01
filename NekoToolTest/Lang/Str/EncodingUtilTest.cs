using System;
using System.Text;
using NekoTool.Lang.Str;
using Xunit;
using Xunit.Abstractions;

namespace NekoToolTest.Lang.Str
{
	public class EncodingUtilTest
	{
		private ITestOutputHelper output;

		public EncodingUtilTest(ITestOutputHelper itoh)
		{
			output = itoh;
		}

		[Fact]
		public void GetEncodingNameTest()
		{
			const CodePage cp0 = CodePage.Utf8;
			const string fact0 = "utf-8";
			Assert.Equal(fact0, EncodingUtil.GetEncodingName(cp0));

			const CodePage cp1 = CodePage.Iso2022jpOneByte;
			const string fact1 = "iso-2022-jp";
			Assert.Equal(fact1, EncodingUtil.GetEncodingName(cp1));

			const CodePage cp2 = CodePage.Default;
			Assert.Null(EncodingUtil.GetEncodingName(cp2));
		}

		[Fact]
		public void GetEncodingTest()
		{
			const CodePage cp0 = CodePage.Utf8;
			Encoding e = Encoding.UTF8;
			Assert.Equal(e, EncodingUtil.GetEncoding(cp0));

			const string data0 = "Hello, world!";
			Assert.Equal(e.GetBytes(data0), EncodingUtil.GetEncodedBytes(data0, cp0));
		}
	}
}
