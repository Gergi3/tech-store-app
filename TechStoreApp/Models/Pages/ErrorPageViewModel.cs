namespace TechStoreApp.Models.Pages;

public class ErrorPageViewModel
{
	public int StatusCode { get; set; }

	public string Title { get; set; } = null!;

	public string Text { get; set; } = null!;
}
