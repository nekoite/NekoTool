using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NekoTool.Lang.Str;

namespace NekoToolTest.Lang.Str
{
	[TestClass]
	public class StringManipTest
	{
		[TestMethod]
		public void SplitAllWhitespaceTest()
		{
			var l = new List<string>() { "I am a ", "good guy", " because I am." };
			var nl = StringManip.SplitAllWhitespace(l);
			Assert.IsTrue(nl.SequenceEqual(new List<string>() { "I", "am", "a", "good", "guy", "because", "I", "am."}));
		}

		[TestMethod]
		public void SplitTest()
		{
			Assert.IsTrue("I\tam good\nso".Split("\\s").SequenceEqual(new List<string> { "I", "am", "good", "so" }));
		}
	}
}
