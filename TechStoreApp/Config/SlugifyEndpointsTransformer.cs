using TechStoreApp.Common.Extensions;

namespace TechStoreApp.Config;

public class SlugifyEndpointsTransformer : IOutboundParameterTransformer
{
	public string TransformOutbound(object? value)
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

		return valueStringified.ToSlug();
	}
}
