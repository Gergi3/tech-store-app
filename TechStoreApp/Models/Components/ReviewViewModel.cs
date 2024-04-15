namespace TechStoreApp.Models.Components;

public class ReviewViewModel
{
	public Guid Id { get; set; }

	public int Stars { get; set; }

	public string Text { get; set; } = null!;

	public string Username { get; set; } = null!;
}
