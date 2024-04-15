using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common;
using TechStoreApp.Infrastructure.Data.Configuration;
using static TechStoreApp.Common.DataConstants.Product;

namespace TechStoreApp.Infrastructure.Data.Entities;

[EntityTypeConfiguration(typeof(ProductConfiguration))]
[Index(nameof(Name), IsUnique = true)]
[Index(nameof(Slug), IsUnique = true)]
public class Product
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public Guid Id { get; set; }

	[Required]
	[StringLength(MaxNameLength)]
	public string Name { get; set; } = null!;

	[Required]
	[StringLength(MaxNameLength)]
	public string Slug { get; set; } = null!;

	public string? Description { get; set; }

	[Required]
	[Column(TypeName = DataConstants.SqlServerTypes.MoneyType)]
	public decimal Price { get; set; }

	public List<Category> Categories { get; } = [];

	public List<Wishlist> Wishlists { get; } = [];

	public List<ExtraInfo> ExtraInfos { get; set; } = [];

	public List<Review> Reviews { get; set; } = [];

	public override string ToString()
	{
		return this.Name.ToString();
	}
}
