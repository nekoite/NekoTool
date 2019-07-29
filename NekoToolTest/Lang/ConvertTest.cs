using NekoTool.Lang;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NekoToolTest.Lang
{
	[TestClass]
	public class ConvertTest
	{
		[TestMethod]
		public void AtoiTest()
		{
			int i = Convert.Atoi("44125");
			Assert.AreEqual(i, 44125);
			i = Convert.Atoi("11ff", 133);
			Assert.AreEqual(i, 133);
		}
	}
}
