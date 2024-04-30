using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static TechStoreApp.Common.DataConstants.Category;

namespace TechStoreApp.Infrastructure.Data.Entities;

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

	[Required]
	[StringLength(MaxNameLength)]
	public string Slug { get; set; } = null!;

	[Required]
	public string ImageUrl { get; set; } = null!;

	public EntityList<Product> Products { get; set; } = [];

	public override string ToString()
	{
		return this.Name;
	}
}
