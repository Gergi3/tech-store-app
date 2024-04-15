using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TechStoreApp.Infrastructure.Data.Entities;

[Index(nameof(UserId), nameof(ProductsId), IsUnique = true)]
public class Review
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public Guid Id { get; set; }

	[Required]
	public int Stars { get; set; }

	[Required]
	public string Text { get; set; } = null!;

	[Required]
	[ForeignKey(nameof(UserId))]
	public virtual AppUser User { get; set; } = null!;
	public Guid UserId { get; set; }

	[Required]
	[ForeignKey(nameof(ProductsId))]
	public virtual Product Product { get; set; } = null!;
	public Guid ProductsId { get; set; }
}
