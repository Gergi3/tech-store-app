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
				dest => dest.Name,
				opt => opt.MapFrom(w => w.Product.Name)
			)
			.ForMember(
				dest => dest.Price,
				opt => opt.MapFrom(w => w.Product.Price)
			)
			.ForMember(
				dest => dest.Slug,
				opt => opt.MapFrom(w => w.Product.Slug)
			);
	}
}
