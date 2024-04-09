using AutoMapper;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Mappers;

public class WishlistProfile : Profile
{
	public WishlistProfile()
	{
		this.CreateMap<Wishlist, WishlistDTO>()
			.ForMember(
				dest => dest.ProductName,
				opt => opt.MapFrom(w => w.Product.Name)
			)
			.ForMember(
				dest => dest.ProductPrice,
				opt => opt.MapFrom(w => w.Product.Price)
			)
			.ForMember(
				dest => dest.ProductSlug,
				opt => opt.MapFrom(w => w.Product.Slug)
			);
	}
}
