using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace NekoTool.Lang
{
	public static class FontLoader
	{
		private static PrivateFontCollection fonts = null;

		public static void LoadFont(byte[] fontData)
		{
			if (fonts == null)
				fonts = new PrivateFontCollection();
			IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
			Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
			uint d = 0;
			fonts.AddMemoryFont(fontPtr, fontData.Length);
			AddFontMemResourceEx(fontPtr, (uint)fontData.Length,
				IntPtr.Zero, ref d);
			Marshal.FreeCoTaskMem(fontPtr);
		}

		public static Font GetFont(string name, float size)
		{
			var fam = fonts.Families.Single(f => f.Name == name);
			return new Font(fam, size);
		}

		[DllImport("gdi32.dll")]
		private static extern IntPtr AddFontMemResourceEx(
			IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
	}
}
