using System;
using Xunit;
using Convert = NekoTool.Lang.Convert;

namespace NekoToolTest.Lang
{
	public class ConvertTest
	{
		[Theory]
		[InlineData("15")]
		[InlineData("abc")]
		[InlineData("ff", 9)]
		public void AtoiTest(string s, int i = 0)
		{
			int res = Convert.Atoi(s, i);
			try
			{
				Assert.Equal(int.Parse(s), res);
			}
			catch (FormatException)
			{
				Assert.Equal(i, res);
			}
		}
	}
}
