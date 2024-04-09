using System.Linq.Expressions;
using AutoMapper;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Mappers;
public class ProductProfile : Profile
{
	public ProductProfile()
	{
		Guid userId = default;
		this.CreateMap<Product, ProductDTO>()
			.ForMember(
				m => m.IsWishlisted,
				opt => opt.MapFrom(
					IsWishlistedMapper(userId))
			);
	}

	private static Expression<Func<Product, bool>> IsWishlistedMapper(Guid userId)
	{
		return src => userId == default
			? false
			: src.Wishlists.Any(x => x.UserId == userId);
	}
}
