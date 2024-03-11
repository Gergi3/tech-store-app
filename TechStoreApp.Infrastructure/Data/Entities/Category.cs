using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Infrastructure.Data.Configuration;
using static TechStoreApp.Common.DataConstants.Category;

namespace TechStoreApp.Infrastructure.Data.Entities;

[EntityTypeConfiguration(typeof(CategoryConfiguration))]
public class Category
{
	[Key]
	public Guid Id { get; set; }

	[Required]
	[StringLength(MaxNameLength)]
	public string Name { get; set; } = null!;

	public List<Product> Products { get; } = [];
}
