using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStoreApp.Infrastructure.Data.Entities;
public class ExtraInfo
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public Guid Id { get; set; }

	[Required]
	public string Name { get; set; } = null!;

	[Required]
	public string Data { get; set; } = null!;

	[ForeignKey(nameof(ProductId))]
	public virtual Product Product { get; set; } = null!;
	public Guid ProductId { get; set; }

	public override string ToString()
	{
		return this.Name;
	}
}
