using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Infrastructure.Data.Configuration;

namespace TechStoreApp.Infrastructure.Data.Entities;

[EntityTypeConfiguration(typeof(ProductCategoryConfiguration))]
public class ProductCategory
{
	[Required]
	[ForeignKey(nameof(Product))]
	public Guid ProductsId { get; set; }
	public Product Product { get; set; } = null!;

	[Required]
	[ForeignKey(nameof(Category))]
	public Guid CategoriesId { get; set; }
	public Category Category { get; set; } = null!;
}
