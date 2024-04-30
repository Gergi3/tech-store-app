using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common;
using static TechStoreApp.Common.DataConstants.Product;

namespace TechStoreApp.Infrastructure.Data.Entities;

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

	[Required]
	public string ImageUrl { get; set; } = null!;

	public virtual EntityList<Category> Categories { get; } = [];

	public virtual EntityList<Session> Sessions { get; } = [];

	public virtual EntityList<ExtraInfo> ExtraInfos { get; set; } = [];

	[Display(AutoGenerateField = false)]
	public virtual EntityList<Review> Reviews { get; set; } = [];

	[Display(AutoGenerateField = false)]
	public virtual EntityList<Order> Orders { get; set; } = [];

	[Display(AutoGenerateField = false)]
	public virtual EntityList<OrderProduct> OrderProducts { get; set; } = [];

	public override string ToString()
	{
		return this.Name.ToString();
	}
}
