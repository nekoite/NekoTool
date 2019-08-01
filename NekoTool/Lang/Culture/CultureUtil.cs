using System.Globalization;
using NekoTool.Lang.Reflection;

namespace NekoTool.Lang.Culture
{
	public static class CultureUtil
	{
		public static string GetCultureName(CultureInfoId id)
		{
			return AttributeUtil.GetAttributeValue(id.GetType(), id.ToString(),
				(CultInfoAttribute a) => a.CultureName);
		}

		public static string GetCultureLanguageName(CultureInfoId id)
		{
			return AttributeUtil.GetAttributeValue(id.GetType(), id.ToString(),
				(CultInfoAttribute a) => a.Language);
		}

		public static CultureInfo GetCultureInfo(CultureInfoId id)
		{
			return CultureInfo.GetCultureInfo((int) id);
		}
	}
}
