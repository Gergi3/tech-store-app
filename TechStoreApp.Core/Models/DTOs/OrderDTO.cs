namespace TechStoreApp.Core.Models.DTOs;
public class OrderDTO
{
	public decimal Price { get; set; }

	public List<ProductDTO> Products { get; set; } = [];
}
