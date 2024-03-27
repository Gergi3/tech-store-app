using System.Globalization;
using System.Text;
using TechStoreApp.Common.Extensions;

namespace TechStoreApp.Config;

public class SlugifyEndpointsTransformer : IOutboundParameterTransformer
{
	public string? TransformOutbound(object? str)
	{
		if (str == null)
		{
			return null!;
		}

		string? valueStringified = str.ToString();

		if (string.IsNullOrEmpty(valueStringified))
		{
			return null!;
		}

		var sb = new StringBuilder();
		for (var i = 0; i < valueStringified.Length; i++)
		{
			if (i != 0
				&& char.IsUpper(valueStringified[i])
				&& char.IsLower(valueStringified[i - 1]))
			{
				sb.Append(CultureInfo.InvariantCulture, $"-{valueStringified[i]}");
			}
			else
			{
				sb.Append(valueStringified[i]);
			}
		}

		return sb.ToString().ToSlug();
	}
}
