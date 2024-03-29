using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace TechStoreApp.Components;

public abstract class BaseViewComponent : ViewComponent
{
	private static readonly Dictionary<string, string> components = GetComponents();

	private static Dictionary<string, string> GetComponents()
	{
		Dictionary<string, string> validDirectories = new();
		var directories = Directory.GetFiles("Components", "*.cshtml", SearchOption.AllDirectories);

		foreach (var dir in directories)
		{
			var dirArr = dir.Split("\\");
			if (dirArr.Length <= 0)
			{
				continue;
			}

			var fileName = dirArr.LastOrDefault() ?? string.Empty;
			if (fileName[0] == '_')
			{
				continue;
			}

			validDirectories[fileName] = $"~/{string.Join("/", dirArr)}";
		}

		return validDirectories;
	}

	public static string? GetViewName(
		string shortName)
	{
		var fileName = string.Format(
			CultureInfo.InvariantCulture,
			"{0}.cshtml",
			shortName);

		components.TryGetValue(fileName, out var value);
		return value;
	}

	private string? CurrentViewName => GetViewName(this.ViewComponentContext.ViewComponentDescriptor.ShortName);

	/// <inheritdoc />
	public new ViewViewComponentResult View()
	{
		var viewName = this.CurrentViewName;

		if (viewName == null)
		{
			return base.View();
		}

		return this.View(viewName: viewName);
	}

	/// <inheritdoc />
	public new ViewViewComponentResult View<TModel>(TModel? model)
	{
		var viewName = this.CurrentViewName;

		if (viewName == null)
		{
			return base.View(model: model);
		}

		return this.View(
			viewName: viewName,
			model: model);
	}
}
