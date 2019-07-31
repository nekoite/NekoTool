
using System;
using System.Text;
using NekoTool.Crypto;
using Xunit;

namespace NekoToolTest.Crypto
{
	public class SecurityUtilTest
	{
		[Fact]
		public void TestStringMD5Default()
		{
			const string testStr = "Hello, world!";
			const string actualHash = "6cd3556deb0da54bca060b4c39479839";
			Assert.Equal(SecurityUtil.GetMD5(testStr), actualHash, true);
		}

		[Fact]
		public void TestBytesMD5()
		{
			byte[] testBytes = Encoding.UTF8.GetBytes("Hello, neko!");
			const string actualHash = "393c788b42b3497ddbe22306d837bbe0";
			Assert.Equal(SecurityUtil.GetMD5(testBytes), actualHash, true);
		}
	}
}
