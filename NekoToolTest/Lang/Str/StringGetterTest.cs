
using System.Collections.Generic;
using NekoTool.Lang.Str;
using Xunit;
using Xunit.Abstractions;

namespace NekoToolTest.Lang.Str
{
	public class StringGetterTest
	{
		private ITestOutputHelper output;

		public StringGetterTest(ITestOutputHelper output)
		{
			this.output = output;
		}

		[Fact]
		public void GetHumanReadableByteCountTest()
		{
			const long num0 = 1024L;
			const string fact0 = "1.0 KiB";
			Assert.Equal(fact0, StringGetter.GetHumanReadableByteCount(num0));

			const long num1 = 16L;
			const string fact1 = "16 B";
			Assert.Equal(fact1, StringGetter.GetHumanReadableByteCount(num1));

			const long num2 = 1000000L;
			const string fact2 = "1.00 MB";
			Assert.Equal(fact2, StringGetter.GetHumanReadableByteCount(num2, true, 2));

			const long num3 = 1_132_951_587L;
			const string fact3 = "1.055 GiB";
			Assert.Equal(fact3, StringGetter.GetHumanReadableByteCount(num3, false, 3));
		}

		[Fact]
		public void GetHexStringTest()
		{
			byte[] data0 = { 0x5a, 0x4b };
			const string fact0 = "5A4B";
			Assert.Equal(fact0, StringGetter.GetHexString(data0));

			byte[] data1 = { 0x06, 0x11, 0xab, 0xca, 0xfe };
			const string fact1 = "06.11.ab.ca.fe";
			Assert.Equal(fact1, StringGetter.GetHexString(data1, "."), true);
		}

		[Fact]
		public void GetStringTest()
		{
			List<int> data0 = new List<int> { 2, 15, 77, 105 };
			const string fact0 = "System.Int32[2, 15, 77, 105]";
			Assert.Equal(fact0, data0.GetString());

			Dictionary<string, int> data1 = new Dictionary<string, int> { { "Hi", 3 }, { "Bye", 4 } };
			const string fact1 = "(System.String, System.Int32)[ {Hi, 3}, {Bye, 4} ]";
			Assert.Equal(fact1, data1.GetString());
		}

		[Theory]
		[InlineData("SGVsbG8sIHdvcmxkIQ==", "Hello, world!")]
		[InlineData("xOO6w6OsysC956Oh", "你好，世界！", CodePage.Gb2312)]
		public void FromBase64StringTest(string base64, string fact, CodePage cp = CodePage.Default)
		{
			if (cp == CodePage.Default)
				Assert.Equal(fact, StringGetter.FromBase64String(base64));
			else
			{
				Assert.Equal(fact, StringGetter.FromBase64String(base64, cp));
				Assert.Equal(fact, StringGetter.FromBase64String(base64, EncodingUtil.GetEncoding(cp)));
			}
		}
	}
}
