namespace TechStoreApp.Core.Models.DTOs;

public class ReviewDTO
{
	public Guid Id { get; set; }

	public int Stars { get; set; }

	public string Text { get; set; } = null!;

	public string Username { get; set; } = null!;
}
