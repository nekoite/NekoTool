using System.ComponentModel;

namespace NekoTool.Lang.Str
{
	/// <summary>
	/// All codepages in one enum with <see cref="EncodingNameAttribute"/> giving its name.
	/// To get its name, use <see cref="EncodingUtil.GetEncodingName"/>.
	/// </summary>
	public enum CodePage
	{
		/// <summary>Default system encoding</summary>
		[Description("Default system encoding")]
		Default = 0,

		/// <summary>IBM EBCDIC (US-Canada)</summary>
		[Description("IBM EBCDIC (US-Canada)")]
		[EncodingName("IBM037")]
		IBM037 = 37,

		/// <summary>OEM United States</summary>
		[Description("OEM United States")]
		[EncodingName("IBM437")]
		IBM437 = 437,

		/// <summary>IBM EBCDIC (International)</summary>
		[Description("IBM EBCDIC (International)")]
		[EncodingName("IBM500")]
		IBM500 = 500,

		/// <summary>Arabic (ASMO 708)</summary>
		[Description("Arabic (ASMO 708)")]
		[EncodingName("ASMO-708")]
		ASMO708 = 708,

		/// <summary>Arabic (DOS)</summary>
		[Description("Arabic (DOS)")]
		[EncodingName("DOS-720")]
		DOS720 = 720,

		/// <summary>Greek (DOS)</summary>
		[Description("Greek (DOS)")]
		[EncodingName("ibm737")]
		Ibm737 = 737,

		/// <summary>Baltic (DOS)</summary>
		[Description("Baltic (DOS)")]
		[EncodingName("ibm775")]
		Ibm775 = 775,

		/// <summary>Western European (DOS)</summary>
		[Description("Western European (DOS)")]
		[EncodingName("ibm850")]
		Ibm850 = 850,

		/// <summary>Central European (DOS)</summary>
		[Description("Central European (DOS)")]
		[EncodingName("ibm852")]
		Ibm852 = 852,

		/// <summary>OEM Cyrillic</summary>
		[Description("OEM Cyrillic")]
		[EncodingName("IBM855")]
		IBM855 = 855,

		/// <summary>Turkish (DOS)</summary>
		[Description("Turkish (DOS)")]
		[EncodingName("ibm857")]
		Ibm857 = 857,

		/// <summary>OEM Multilingual Latin I</summary>
		[Description("OEM Multilingual Latin I")]
		[EncodingName("IBM00858")]
		IBM00858 = 858,

		/// <summary>Portuguese (DOS)</summary>
		[Description("Portuguese (DOS)")]
		[EncodingName("IBM860")]
		IBM860 = 860,

		/// <summary>Icelandic (DOS)</summary>
		[Description("Icelandic (DOS)")]
		[EncodingName("ibm861")]
		Ibm861 = 861,

		/// <summary>Hebrew (DOS)</summary>
		[Description("Hebrew (DOS)")]
		[EncodingName("DOS-862")]
		DOS862 = 862,

		/// <summary>French Canadian (DOS)</summary>
		[Description("French Canadian (DOS)")]
		[EncodingName("IBM863")]
		IBM863 = 863,

		/// <summary>Arabic (864)</summary>
		[Description("Arabic (864)")]
		[EncodingName("IBM864")]
		IBM864 = 864,

		/// <summary>Nordic (DOS)</summary>
		[Description("Nordic (DOS)")]
		[EncodingName("IBM865")]
		IBM865 = 865,

		/// <summary>Cyrillic (DOS)</summary>
		[Description("Cyrillic (DOS)")]
		[EncodingName("cp866")]
		Cp866 = 866,

		/// <summary>Greek, Modern (DOS)</summary>
		[Description("Greek, Modern (DOS)")]
		[EncodingName("ibm869")]
		Ibm869 = 869,

		/// <summary>IBM EBCDIC (Multilingual Latin-2)</summary>
		[Description("IBM EBCDIC (Multilingual Latin-2)")]
		[EncodingName("IBM870")]
		IBM870 = 870,

		/// <summary>Thai (Windows)</summary>
		[Description("Thai (Windows)")]
		[EncodingName("windows-874")]
		Windows874 = 874,

		/// <summary>IBM EBCDIC (Greek Modern)</summary>
		[Description("IBM EBCDIC (Greek Modern)")]
		[EncodingName("cp875")]
		Cp875 = 875,

		/// <summary>Japanese (Shift-JIS)</summary>
		[Description("Japanese (Shift-JIS)")]
		[EncodingName("shift_jis")]
		Shiftjis = 932,

		/// <summary>Chinese Simplified (GB2312)</summary>
		[Description("Chinese Simplified (GB2312)")]
		[EncodingName("gb2312")]
		Gb2312 = 936,

		/// <summary>Korean</summary>
		[Description("Korean")]
		[EncodingName("ks_c_5601-1987")]
		Ksc56011987 = 949,

		/// <summary>Chinese Traditional (Big5)</summary>
		[Description("Chinese Traditional (Big5)")]
		[EncodingName("big5")]
		Big5 = 950,

		/// <summary>IBM EBCDIC (Turkish Latin-5)</summary>
		[Description("IBM EBCDIC (Turkish Latin-5)")]
		[EncodingName("IBM1026")]
		IBM1026 = 1026,

		/// <summary>IBM Latin-1</summary>
		[Description("IBM Latin-1")]
		[EncodingName("IBM01047")]
		IBM01047 = 1047,

		/// <summary>IBM EBCDIC (US-Canada-Euro)</summary>
		[Description("IBM EBCDIC (US-Canada-Euro)")]
		[EncodingName("IBM01140")]
		IBM01140 = 1140,

		/// <summary>IBM EBCDIC (Germany-Euro)</summary>
		[Description("IBM EBCDIC (Germany-Euro)")]
		[EncodingName("IBM01141")]
		IBM01141 = 1141,

		/// <summary>IBM EBCDIC (Denmark-Norway-Euro)</summary>
		[Description("IBM EBCDIC (Denmark-Norway-Euro)")]
		[EncodingName("IBM01142")]
		IBM01142 = 1142,

		/// <summary>IBM EBCDIC (Finland-Sweden-Euro)</summary>
		[Description("IBM EBCDIC (Finland-Sweden-Euro)")]
		[EncodingName("IBM01143")]
		IBM01143 = 1143,

		/// <summary>IBM EBCDIC (Italy-Euro)</summary>
		[Description("IBM EBCDIC (Italy-Euro)")]
		[EncodingName("IBM01144")]
		IBM01144 = 1144,

		/// <summary>IBM EBCDIC (Spain-Euro)</summary>
		[Description("IBM EBCDIC (Spain-Euro)")]
		[EncodingName("IBM01145")]
		IBM01145 = 1145,

		/// <summary>IBM EBCDIC (UK-Euro)</summary>
		[Description("IBM EBCDIC (UK-Euro)")]
		[EncodingName("IBM01146")]
		IBM01146 = 1146,

		/// <summary>IBM EBCDIC (France-Euro)</summary>
		[Description("IBM EBCDIC (France-Euro)")]
		[EncodingName("IBM01147")]
		IBM01147 = 1147,

		/// <summary>IBM EBCDIC (International-Euro)</summary>
		[Description("IBM EBCDIC (International-Euro)")]
		[EncodingName("IBM01148")]
		IBM01148 = 1148,

		/// <summary>IBM EBCDIC (Icelandic-Euro)</summary>
		[Description("IBM EBCDIC (Icelandic-Euro)")]
		[EncodingName("IBM01149")]
		IBM01149 = 1149,

		/// <summary>Unicode</summary>
		[Description("Unicode")]
		[EncodingName("utf-16")]
		Utf16 = 1200,

		/// <summary>Unicode (Big endian)</summary>
		[Description("Unicode (Big endian)")]
		[EncodingName("unicodeFFFE")]
		UnicodeFFFE = 1201,

		/// <summary>Central European (Windows)</summary>
		[Description("Central European (Windows)")]
		[EncodingName("windows-1250")]
		Windows1250 = 1250,

		/// <summary>Cyrillic (Windows)</summary>
		[Description("Cyrillic (Windows)")]
		[EncodingName("windows-1251")]
		Windows1251 = 1251,

		/// <summary>Western European (Windows)</summary>
		[Description("Western European (Windows)")]
		[EncodingName("Windows-1252")]
		Windows1252 = 1252,

		/// <summary>Greek (Windows)</summary>
		[Description("Greek (Windows)")]
		[EncodingName("windows-1253")]
		Windows1253 = 1253,

		/// <summary>Turkish (Windows)</summary>
		[Description("Turkish (Windows)")]
		[EncodingName("windows-1254")]
		Windows1254 = 1254,

		/// <summary>Hebrew (Windows)</summary>
		[Description("Hebrew (Windows)")]
		[EncodingName("windows-1255")]
		Windows1255 = 1255,

		/// <summary>Arabic (Windows)</summary>
		[Description("Arabic (Windows)")]
		[EncodingName("windows-1256")]
		Windows1256 = 1256,

		/// <summary>Baltic (Windows)</summary>
		[Description("Baltic (Windows)")]
		[EncodingName("windows-1257")]
		Windows1257 = 1257,

		/// <summary>Vietnamese (Windows)</summary>
		[Description("Vietnamese (Windows)")]
		[EncodingName("windows-1258")]
		Windows1258 = 1258,

		/// <summary>Korean (Johab)</summary>
		[Description("Korean (Johab)")]
		[EncodingName("Johab")]
		Johab = 1361,

		/// <summary>Western European (Mac)</summary>
		[Description("Western European (Mac)")]
		[EncodingName("macintosh")]
		Macintosh = 10000,

		/// <summary>Japanese (Mac)</summary>
		[Description("Japanese (Mac)")]
		[EncodingName("x-mac-japanese")]
		Xmacjapanese = 10001,

		/// <summary>Chinese Traditional (Mac)</summary>
		[Description("Chinese Traditional (Mac)")]
		[EncodingName("x-mac-chinesetrad")]
		Xmacchinesetrad = 10002,

		/// <summary>Korean (Mac)</summary>
		[Description("Korean (Mac)")]
		[EncodingName("x-mac-korean")]
		Xmackorean = 10003,

		/// <summary>Arabic (Mac)</summary>
		[Description("Arabic (Mac)")]
		[EncodingName("x-mac-arabic")]
		Xmacarabic = 10004,

		/// <summary>Hebrew (Mac)</summary>
		[Description("Hebrew (Mac)")]
		[EncodingName("x-mac-hebrew")]
		Xmachebrew = 10005,

		/// <summary>Greek (Mac)</summary>
		[Description("Greek (Mac)")]
		[EncodingName("x-mac-greek")]
		Xmacgreek = 10006,

		/// <summary>Cyrillic (Mac)</summary>
		[Description("Cyrillic (Mac)")]
		[EncodingName("x-mac-cyrillic")]
		Xmaccyrillic = 10007,

		/// <summary>Chinese Simplified (Mac)</summary>
		[Description("Chinese Simplified (Mac)")]
		[EncodingName("x-mac-chinesesimp")]
		Xmacchinesesimp = 10008,

		/// <summary>Romanian (Mac)</summary>
		[Description("Romanian (Mac)")]
		[EncodingName("x-mac-romanian")]
		Xmacromanian = 10010,

		/// <summary>Ukrainian (Mac)</summary>
		[Description("Ukrainian (Mac)")]
		[EncodingName("x-mac-ukrainian")]
		Xmacukrainian = 10017,

		/// <summary>Thai (Mac)</summary>
		[Description("Thai (Mac)")]
		[EncodingName("x-mac-thai")]
		Xmacthai = 10021,

		/// <summary>Central European (Mac)</summary>
		[Description("Central European (Mac)")]
		[EncodingName("x-mac-ce")]
		Xmacce = 10029,

		/// <summary>Icelandic (Mac)</summary>
		[Description("Icelandic (Mac)")]
		[EncodingName("x-mac-icelandic")]
		Xmacicelandic = 10079,

		/// <summary>Turkish (Mac)</summary>
		[Description("Turkish (Mac)")]
		[EncodingName("x-mac-turkish")]
		Xmacturkish = 10081,

		/// <summary>Croatian (Mac)</summary>
		[Description("Croatian (Mac)")]
		[EncodingName("x-mac-croatian")]
		Xmaccroatian = 10082,

		/// <summary>Unicode (UTF-32)</summary>
		[Description("Unicode (UTF-32)")]
		[EncodingName("utf-32")]
		Utf32 = 12000,

		/// <summary>Unicode (UTF-32 Big endian)</summary>
		[Description("Unicode (UTF-32 Big endian)")]
		[EncodingName("utf-32BE")]
		Utf32BE = 12001,

		/// <summary>Chinese Traditional (CNS)</summary>
		[Description("Chinese Traditional (CNS)")]
		[EncodingName("x-Chinese-CNS")]
		XChineseCNS = 20000,

		/// <summary>TCA Taiwan</summary>
		[Description("TCA Taiwan")]
		[EncodingName("x-cp20001")]
		Xcp20001 = 20001,

		/// <summary>Chinese Traditional (Eten)</summary>
		[Description("Chinese Traditional (Eten)")]
		[EncodingName("x-Chinese-Eten")]
		XChineseEten = 20002,

		/// <summary>IBM5550 Taiwan</summary>
		[Description("IBM5550 Taiwan")]
		[EncodingName("x-cp20003")]
		Xcp20003 = 20003,

		/// <summary>TeleText Taiwan</summary>
		[Description("TeleText Taiwan")]
		[EncodingName("x-cp20004")]
		Xcp20004 = 20004,

		/// <summary>Wang Taiwan</summary>
		[Description("Wang Taiwan")]
		[EncodingName("x-cp20005")]
		Xcp20005 = 20005,

		/// <summary>Western European (IA5)</summary>
		[Description("Western European (IA5)")]
		[EncodingName("x-IA5")]
		XIA5 = 20105,

		/// <summary>German (IA5)</summary>
		[Description("German (IA5)")]
		[EncodingName("x-IA5-German")]
		XIA5German = 20106,

		/// <summary>Swedish (IA5)</summary>
		[Description("Swedish (IA5)")]
		[EncodingName("x-IA5-Swedish")]
		XIA5Swedish = 20107,

		/// <summary>Norwegian (IA5)</summary>
		[Description("Norwegian (IA5)")]
		[EncodingName("x-IA5-Norwegian")]
		XIA5Norwegian = 20108,

		/// <summary>US-ASCII</summary>
		[Description("US-ASCII")]
		[EncodingName("us-ascii")]
		UsAscii = 20127,

		/// <summary>T.61</summary>
		[Description("T.61")]
		[EncodingName("x-cp20261")]
		Xcp20261 = 20261,

		/// <summary>ISO-6937</summary>
		[Description("ISO-6937")]
		[EncodingName("x-cp20269")]
		Xcp20269 = 20269,

		/// <summary>IBM EBCDIC (Germany)</summary>
		[Description("IBM EBCDIC (Germany)")]
		[EncodingName("IBM273")]
		IBM273 = 20273,

		/// <summary>IBM EBCDIC (Denmark-Norway)</summary>
		[Description("IBM EBCDIC (Denmark-Norway)")]
		[EncodingName("IBM277")]
		IBM277 = 20277,

		/// <summary>IBM EBCDIC (Finland-Sweden)</summary>
		[Description("IBM EBCDIC (Finland-Sweden)")]
		[EncodingName("IBM278")]
		IBM278 = 20278,

		/// <summary>IBM EBCDIC (Italy)</summary>
		[Description("IBM EBCDIC (Italy)")]
		[EncodingName("IBM280")]
		IBM280 = 20280,

		/// <summary>IBM EBCDIC (Spain)</summary>
		[Description("IBM EBCDIC (Spain)")]
		[EncodingName("IBM284")]
		IBM284 = 20284,

		/// <summary>IBM EBCDIC (UK)</summary>
		[Description("IBM EBCDIC (UK)")]
		[EncodingName("IBM285")]
		IBM285 = 20285,

		/// <summary>IBM EBCDIC (Japanese katakana)</summary>
		[Description("IBM EBCDIC (Japanese katakana)")]
		[EncodingName("IBM290")]
		IBM290 = 20290,

		/// <summary>IBM EBCDIC (France)</summary>
		[Description("IBM EBCDIC (France)")]
		[EncodingName("IBM297")]
		IBM297 = 20297,

		/// <summary>IBM EBCDIC (Arabic)</summary>
		[Description("IBM EBCDIC (Arabic)")]
		[EncodingName("IBM420")]
		IBM420 = 20420,

		/// <summary>IBM EBCDIC (Greek)</summary>
		[Description("IBM EBCDIC (Greek)")]
		[EncodingName("IBM423")]
		IBM423 = 20423,

		/// <summary>IBM EBCDIC (Hebrew)</summary>
		[Description("IBM EBCDIC (Hebrew)")]
		[EncodingName("IBM424")]
		IBM424 = 20424,

		/// <summary>IBM EBCDIC (Korean Extended)</summary>
		[Description("IBM EBCDIC (Korean Extended)")]
		[EncodingName("x-EBCDIC-KoreanExtended")]
		XEBCDICKoreanExtended = 20833,

		/// <summary>IBM EBCDIC (Thai)</summary>
		[Description("IBM EBCDIC (Thai)")]
		[EncodingName("IBM-Thai")]
		IBMThai = 20838,

		/// <summary>Cyrillic (KOI8-R)</summary>
		[Description("Cyrillic (KOI8-R)")]
		[EncodingName("koi8-r")]
		Koi8r = 20866,

		/// <summary>IBM EBCDIC (Icelandic)</summary>
		[Description("IBM EBCDIC (Icelandic)")]
		[EncodingName("IBM871")]
		IBM871 = 20871,

		/// <summary>IBM EBCDIC (Cyrillic Russian)</summary>
		[Description("IBM EBCDIC (Cyrillic Russian)")]
		[EncodingName("IBM880")]
		IBM880 = 20880,

		/// <summary>IBM EBCDIC (Turkish)</summary>
		[Description("IBM EBCDIC (Turkish)")]
		[EncodingName("IBM905")]
		IBM905 = 20905,

		/// <summary>IBM Latin-1</summary>
		[Description("IBM Latin-1")]
		[EncodingName("IBM00924")]
		IBM00924 = 20924,

		/// <summary>Japanese (JIS 0208-1990 and 0212-1990)</summary>
		[Description("Japanese (JIS 0208-1990 and 0212-1990)")]
		[EncodingName("EUC-JP")]
		EUCJP_1990 = 20932,

		/// <summary>Chinese Simplified (GB2312-80)</summary>
		[Description("Chinese Simplified (GB2312-80)")]
		[EncodingName("x-cp20936")]
		Xcp20936 = 20936,

		/// <summary>Korean Wansung</summary>
		[Description("Korean Wansung")]
		[EncodingName("x-cp20949")]
		Xcp20949 = 20949,

		/// <summary>IBM EBCDIC (Cyrillic Serbian-Bulgarian)</summary>
		[Description("IBM EBCDIC (Cyrillic Serbian-Bulgarian)")]
		[EncodingName("cp1025")]
		Cp1025 = 21025,

		/// <summary>Cyrillic (KOI8-U)</summary>
		[Description("Cyrillic (KOI8-U)")]
		[EncodingName("koi8-u")]
		Koi8u = 21866,

		/// <summary>Western European (ISO)</summary>
		[Description("Western European (ISO)")]
		[EncodingName("iso-8859-1")]
		Iso88591 = 28591,

		/// <summary>Central European (ISO)</summary>
		[Description("Central European (ISO)")]
		[EncodingName("iso-8859-2")]
		Iso88592 = 28592,

		/// <summary>Latin 3 (ISO)</summary>
		[Description("Latin 3 (ISO)")]
		[EncodingName("iso-8859-3")]
		Iso88593 = 28593,

		/// <summary>Baltic (ISO)</summary>
		[Description("Baltic (ISO)")]
		[EncodingName("iso-8859-4")]
		Iso88594 = 28594,

		/// <summary>Cyrillic (ISO)</summary>
		[Description("Cyrillic (ISO)")]
		[EncodingName("iso-8859-5")]
		Iso88595 = 28595,

		/// <summary>Arabic (ISO)</summary>
		[Description("Arabic (ISO)")]
		[EncodingName("iso-8859-6")]
		Iso88596 = 28596,

		/// <summary>Greek (ISO)</summary>
		[Description("Greek (ISO)")]
		[EncodingName("iso-8859-7")]
		Iso88597 = 28597,

		/// <summary>Hebrew (ISO-Visual)</summary>
		[Description("Hebrew (ISO-Visual)")]
		[EncodingName("iso-8859-8")]
		Iso88598 = 28598,

		/// <summary>Turkish (ISO)</summary>
		[Description("Turkish (ISO)")]
		[EncodingName("iso-8859-9")]
		Iso88599 = 28599,

		/// <summary>Estonian (ISO)</summary>
		[Description("Estonian (ISO)")]
		[EncodingName("iso-8859-13")]
		Iso885913 = 28603,

		/// <summary>Latin 9 (ISO)</summary>
		[Description("Latin 9 (ISO)")]
		[EncodingName("iso-8859-15")]
		Iso885915 = 28605,

		/// <summary>Europa</summary>
		[Description("Europa")]
		[EncodingName("x-Europa")]
		XEuropa = 29001,

		/// <summary>Hebrew (ISO-Logical)</summary>
		[Description("Hebrew (ISO-Logical)")]
		[EncodingName("iso-8859-8-i")]
		Iso88598i = 38598,

		/// <summary>Japanese (JIS)</summary>
		[Description("Japanese (JIS)")]
		[EncodingName("iso-2022-jp")]
		Iso2022jp = 50220,

		/// <summary>Japanese (JIS-Allow 1 byte Kana)</summary>
		[Description("Japanese (JIS-Allow 1 byte Kana)")]
		[EncodingName("csISO2022JP")]
		CsISO2022JP = 50221,

		/// <summary>Japanese (JIS-Allow 1 byte Kana - SO/SI)</summary>
		[Description("Japanese (JIS-Allow 1 byte Kana - SO/SI)")]
		[EncodingName("iso-2022-jp")]
		Iso2022jpOneByte = 50222,

		/// <summary>Korean (ISO)</summary>
		[Description("Korean (ISO)")]
		[EncodingName("iso-2022-kr")]
		Iso2022kr = 50225,

		/// <summary>Chinese Simplified (ISO-2022)</summary>
		[Description("Chinese Simplified (ISO-2022)")]
		[EncodingName("x-cp50227")]
		Xcp50227 = 50227,

		/// <summary>Japanese (EUC)</summary>
		[Description("Japanese (EUC)")]
		[EncodingName("euc-jp")]
		Eucjp = 51932,

		/// <summary>Chinese Simplified (EUC)</summary>
		[Description("Chinese Simplified (EUC)")]
		[EncodingName("EUC-CN")]
		EUCCN = 51936,

		/// <summary>Korean (EUC)</summary>
		[Description("Korean (EUC)")]
		[EncodingName("euc-kr")]
		Euckr = 51949,

		/// <summary>Chinese Simplified (HZ)</summary>
		[Description("Chinese Simplified (HZ)")]
		[EncodingName("hz-gb-2312")]
		Hzgb2312 = 52936,

		/// <summary>Chinese Simplified (GB18030)</summary>
		[Description("Chinese Simplified (GB18030)")]
		[EncodingName("GB18030")]
		GB18030 = 54936,

		/// <summary>ISCII Devanagari</summary>
		[Description("ISCII Devanagari")]
		[EncodingName("x-iscii-de")]
		Xisciide = 57002,

		/// <summary>ISCII Bengali</summary>
		[Description("ISCII Bengali")]
		[EncodingName("x-iscii-be")]
		Xisciibe = 57003,

		/// <summary>ISCII Tamil</summary>
		[Description("ISCII Tamil")]
		[EncodingName("x-iscii-ta")]
		Xisciita = 57004,

		/// <summary>ISCII Telugu</summary>
		[Description("ISCII Telugu")]
		[EncodingName("x-iscii-te")]
		Xisciite = 57005,

		/// <summary>ISCII Assamese</summary>
		[Description("ISCII Assamese")]
		[EncodingName("x-iscii-as")]
		Xisciias = 57006,

		/// <summary>ISCII Oriya</summary>
		[Description("ISCII Oriya")]
		[EncodingName("x-iscii-or")]
		Xisciior = 57007,

		/// <summary>ISCII Kannada</summary>
		[Description("ISCII Kannada")]
		[EncodingName("x-iscii-ka")]
		Xisciika = 57008,

		/// <summary>ISCII Malayalam</summary>
		[Description("ISCII Malayalam")]
		[EncodingName("x-iscii-ma")]
		Xisciima = 57009,

		/// <summary>ISCII Gujarati</summary>
		[Description("ISCII Gujarati")]
		[EncodingName("x-iscii-gu")]
		Xisciigu = 57010,

		/// <summary>ISCII Punjabi</summary>
		[Description("ISCII Punjabi")]
		[EncodingName("x-iscii-pa")]
		Xisciipa = 57011,

		/// <summary>Unicode (UTF-7)</summary>
		[Description("Unicode (UTF-7)")]
		[EncodingName("utf-7")]
		Utf7 = 65000,

		/// <summary>Unicode (UTF-8)</summary>
		[Description("Unicode (UTF-8)")]
		[EncodingName("utf-8")]
		Utf8 = 65001
	}
}