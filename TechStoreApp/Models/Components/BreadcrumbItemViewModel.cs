namespace TechStoreApp.Models.Components;

public class BreadcrumbItemViewModel
{
	public string Name { get; set; } = null!;

	public (string ControllerName, string ActionName)? Path { get; set; }
}
