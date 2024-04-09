using System.ComponentModel.DataAnnotations;
using static TechStoreApp.Common.QueryConstants.Category;

namespace TechStoreApp.Core.Models.Params;

public class CategoryQueryParams
{
	[Required]
	[Range(0, int.MaxValue)]
	public int Skip { get; set; } = DefaultSkip;

	[Required]
	[Range(1, 24)]
	public int Take { get; set; } = DefaultTake;
}
