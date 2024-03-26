using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Infrastructure.Data.Configuration;
using static TechStoreApp.Common.DataConstants.Category;

namespace TechStoreApp.Infrastructure.Data.Entities;

[EntityTypeConfiguration(typeof(CategoryConfiguration))]
[Index(nameof(Name), IsUnique = true)]
[Index(nameof(Slug), IsUnique = true)]
public class Category
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public Guid Id { get; set; }

	[Required]
	[StringLength(MaxNameLength)]
	public string Name { get; set; } = null!;

	[StringLength(MaxNameLength)]
	public string? Slug { get; set; }

	public List<Product> Products { get; } = [];

	public override string ToString()
	{
		return this.Name.ToString();
	}
}
