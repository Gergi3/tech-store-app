using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Infrastructure.Data.Configuration;

namespace TechStoreApp.Infrastructure.Data.Entities;

[EntityTypeConfiguration(typeof(ProductCategoryConfiguration))]
public class ProductCategory
{
	[Required]
	[ForeignKey(nameof(ProductsId))]
	public virtual Product Product { get; set; } = null!;
	public Guid ProductsId { get; set; }

	[Required]
	[ForeignKey(nameof(CategoriesId))]
	public virtual Category Category { get; set; } = null!;
	public Guid CategoriesId { get; set; }
}
