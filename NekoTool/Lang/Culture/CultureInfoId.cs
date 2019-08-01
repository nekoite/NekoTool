
namespace NekoTool.Lang.Culture
{
	/// <summary>
	/// <para>
	/// Gets the id of some cultures / languages. To get the name, use
	/// <see cref="CultureUtil.GetCultureName"/>.
	/// </para>
	/// 
	/// <remarks>
	/// For more information on sorting, see https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=netframework-4.8.
	/// "Supported by" is the release version of Windows.
	/// </remarks>
	/// </summary>
	public enum CultureInfoId
	{
		/// <summary>
		/// Spanish with international sorting.
		/// </summary>
		[CultInfo("es-ES", "Spanish")]
		Spanish = 0x0c0a,

		/// <summary>
		/// Spanish with traditional sorting.
		/// </summary>
		[CultInfo("es-ES_tradnl", "Spanish")]
		SpanishTraditional = 0x040a,

		/// <summary>
		/// Simplified Chinese sorted by pronunciation.
		/// </summary>
		[CultInfo("zh-CN", "Chinese (Simplified)")]
		ChineseSimpPronunciation = 0x0804,

		/// <summary>
		/// Simplified Chinese sorted by strokes.
		/// </summary>
		[CultInfo("zh-CN", "Chinese (Simplified)")]
		ChineseSimpStroke = 0x20804,

		/// <summary>
		/// Traditional Chinese (Taiwan).
		/// </summary>
		[CultInfo("zh-TW", "Chinese (Traditional)")]
		ChineseTradTaiwan = 0x0404,

		/// <summary>
		/// Japanese sorted by default.
		/// </summary>
		[CultInfo("ja-JP", "Japanese")]
		Japanese = 0x0411,

		/// <summary>
		/// Korean.
		/// </summary>
		[CultInfo("ko-KR", "Korean")]
		Korean = 0x0412,

		/// <summary>
		/// North Korean (supported Release 10.1).
		/// </summary>
		[CultInfo("ko-KP", "North Korean")]
		NorthKorean = 0x1000,

		/// <summary>
		/// German (Germany).
		/// </summary>
		[CultInfo("de-DE", "German")]
		German = 0x0407,

		/// <summary>
		/// French (France).
		/// </summary>
		[CultInfo("fr-FR", "French")]
		French = 0x040c,


	}
}
