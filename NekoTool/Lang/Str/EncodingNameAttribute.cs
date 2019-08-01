using System;

namespace NekoTool.Lang.Str
{
	[AttributeUsage(AttributeTargets.Field)]
	sealed class EncodingNameAttribute : Attribute
	{
		public string EncodingName { get; }

		public EncodingNameAttribute(string encodingName)
		{
			EncodingName = encodingName;
		}
	}
}
