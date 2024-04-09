namespace TechStoreApp.Models.Components;

public class ProductPaginationViewModel
{
	public int Page { get; set; }

	public int PerPage { get; set; }

	public int TotalCount { get; set; }

	public int PreviousPage { get; set; }

	public int NextPage { get; set; }

	public int FirstPage { get; set; }

	public int LastPage { get; set; }

	public int ShowingFrom { get; set; }

	public int ShowingTo { get; set; }
}
