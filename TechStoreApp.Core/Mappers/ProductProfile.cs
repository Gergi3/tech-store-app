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
			.ForMember(dest => dest.Categories, opt => opt.ExplicitExpansion())
			.ForMember(dest => dest.ExtraInfos, opt => opt.ExplicitExpansion())
			.ForMember(dest => dest.Reviews, opt => opt.ExplicitExpansion())
			.ForMember(
				p => p.IsWishlisted,
				opt => opt.MapFrom(
					IsWishlistedMapper(userId))
			)
			.ForMember(
				dest => dest.AverageRating,
				opt => opt.MapFrom(
					p => p.Reviews.Count > 0
						? p.Reviews
							.Select(x => x.Stars)
							.Average()
						: default)
				);
	}

	private static Expression<Func<Product, bool>> IsWishlistedMapper(Guid userId)
	{
		return src => userId == default
			? false
			: src.Wishlists.Any(x => x.UserId == userId);
	}
}
