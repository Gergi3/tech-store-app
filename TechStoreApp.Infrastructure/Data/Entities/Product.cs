using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common;
using TechStoreApp.Infrastructure.Data.Configuration;
using static TechStoreApp.Common.DataConstants.Product;

namespace TechStoreApp.Infrastructure.Data.Entities;

[EntityTypeConfiguration(typeof(ProductConfiguration))]
public class Product
{
	[Key]
	public Guid Id { get; set; }

	[Required]
	[StringLength(MaxNameLength)]
	public string Name { get; set; } = null!;

	[Required]
	[Column(TypeName = DataConstants.SqlServerTypes.MoneyType)]
	public decimal Price { get; set; }

	public List<Category> Categories { get; } = [];
}
