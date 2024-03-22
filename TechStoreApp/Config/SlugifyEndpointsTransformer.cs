using System.Text.RegularExpressions;

namespace TechStoreApp.Config;

public class SlugifyEndpointsTransformer : IOutboundParameterTransformer
{
	public string TransformOutbound(object value)
	{
		if (value == null)
		{
			return null!;
		}

		string? valueStringified = value.ToString();

		if (string.IsNullOrEmpty(valueStringified))
		{
			return null!;
		}

		string regex = "([a-z])([A-Z])";
		string result = Regex.Replace(valueStringified, regex, "$1-$2");

		return result.ToLower();
	}
}
