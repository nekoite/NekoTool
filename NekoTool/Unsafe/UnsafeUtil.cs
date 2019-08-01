
using System;
using System.IO;

namespace NekoTool.Unsafe
{
	public static unsafe class UnsafeUtil
	{
		public static void DisplayString(char* pc)
		{
			DisplayString(Console.Out, pc);
		}

		public static void DisplayString(TextWriter writer, char* pc)
		{
			for (int i = 0; pc[i] != 0; i++)
			{
				writer.Write(pc[i]);
			}
		}
	}
}
