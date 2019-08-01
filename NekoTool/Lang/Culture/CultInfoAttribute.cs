using System;

namespace NekoTool.Lang.Culture
{
	[AttributeUsage(AttributeTargets.Field)]
	public class CultInfoAttribute : Attribute
	{
		/// <summary>
		/// The same as "Language tag", for more information, see
		/// https://docs.microsoft.com/en-us/openspecs/windows_protocols/ms-lcid/a9eac961-e77d-41a6-90a5-ce1a8b0cdb9c .
		///
		/// This is the only key for the culture info.
		/// </summary>
		public string CultureName { get; }

		/// <summary>
		/// The language in use for the culture info.
		/// </summary>
		public string Language { get; }

		public CultInfoAttribute(string name, string language)
		{
			CultureName = name;
			Language = language;
		}
	}
}
