namespace TechStoreApp.Core.Models;

public class ProductQueryParamsDTO
{
	public string? CategorySlug { get; set; }
	public int Page { get; set; }
	public int PerPage { get; set; }
}
