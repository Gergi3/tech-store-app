using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechStoreApp.Common.Extensions;

namespace TechStoreApp.Infrastructure.Data.Converters;

public class SlugValueConverter : ValueConverter<string, string>
{
	private static readonly Expression<Func<string, string>> _getter =
		s => s;

	private static readonly Expression<Func<string, string>> _setter =
		s => s.ToSlug();

	public SlugValueConverter()
		: base(_setter, _getter)
	{ }
}
