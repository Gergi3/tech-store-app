using System.ComponentModel.DataAnnotations;
using static TechStoreApp.Common.QueryConstants.Product;

namespace TechStoreApp.Core.Models.DTOs;

public class ProductQueryParams
{
	public string? CategorySlug { get; set; }

	[Range(typeof(decimal), "0", "79228162514264337593543950335")]
	public decimal? ToPrice { get; set; }

	[Range(typeof(decimal), "0", "79228162514264337593543950335")]
	public decimal? FromPrice { get; set; }

	[Required]
	[Range(0, int.MaxValue)]
	public int Page { get; set; } = DefaultFirstPage;

	[Required]
	[Range(0, 24)]
	public int PerPage { get; set; } = DefaultPerPage;
}
