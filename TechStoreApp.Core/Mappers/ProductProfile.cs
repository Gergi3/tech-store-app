using System.Linq.Expressions;
using AutoMapper;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Entities;
using TechStoreApp.Infrastructure.Data.EnumTypes;

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
			.ForMember(dest => dest.ReviewsCount, opt => opt.ExplicitExpansion())
			.ForMember(
				p => p.IsWishlisted,
				opt => opt.MapFrom(
					SessionMapper(userId, SessionStatus.Wishlisted))
			)
			.ForMember(
				p => p.IsInCart,
				opt => opt.MapFrom(
					SessionMapper(userId, SessionStatus.InCart))
			)
			.ForMember(
				dest => dest.ReviewsCount,
				opt => opt.MapFrom(p => p.Reviews.Count)
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

	private static Expression<Func<Product, bool>> SessionMapper(Guid userId, SessionStatus status)
	{
		return src => userId == default
			? false
			: src.Sessions.Any(s => s.UserId == userId && s.Status == status);
	}
}
