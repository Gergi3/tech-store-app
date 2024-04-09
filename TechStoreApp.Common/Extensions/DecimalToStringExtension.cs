using System.Globalization;

namespace TechStoreApp.Common.Extensions;

public static class DecimalToStringExtension
{
	public static string ToPriceString(this decimal num)
	{
		return string.Format(CultureInfo.InvariantCulture, "${0:F2}", num);
	}
}
