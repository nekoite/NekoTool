using System;

namespace NekoTool.Lang.Str
{
	/// <summary>
	/// Attribute class for recording the encoding name of a specific <see cref="CodePage"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class EncodingNameAttribute : Attribute
	{
		/// <summary>
		/// The encoding name.
		/// </summary>
		public string EncodingName { get; }

		public EncodingNameAttribute(string encodingName)
		{
			EncodingName = encodingName;
		}
	}
}
