
using NekoTool.Lang.Str;
using Xunit;

namespace NekoToolTest.Lang.Str
{
	public class NekoSBTest
	{
		private NekoSB sb;

		[Fact]
		public void Test()
		{
			MakeSBTest();
			AppendTest();
		}

		private void MakeSBTest()
		{
			sb = new NekoSB();
			Assert.Equal(0, sb.Length);
		}

		private void AppendTest()
		{
			const string t = "Hello.";
			sb.Append(t);
			Assert.Equal(t, sb.ToString());
			Assert.Equal(6, sb.Length);
		}
	}
}
