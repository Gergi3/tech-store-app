using System.Globalization;
using AutoMapper;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Mappers;

public class ViewComponentsProfile : Profile
{
	public ViewComponentsProfile()
	{
		this.CreateMap<CategoryDTO, CategoryFilterViewModel>();
		this.CreateMap<CategoryDTO, CategoryItemViewModel>();
		this.CreateMap<CategoryDTO, ProductItemCategoriesViewModel>();
		this.CreateMap<CategoryDTO, ProductDetailsCategoriesViewModel>();

		this.CreateMap<WishlistDTO, WishlistItemViewModel>()
			.ForMember(
				dest => dest.Price,
				src => src.MapFrom(
					x => string.Format(CultureInfo.InvariantCulture, "${0:F2}", x.Price))
			);

		this.CreateMap<ProductDTO, ProductDetailsTopViewModel>()
			.ForMember(
				dest => dest.Price,
				src => src.MapFrom(
					x => string.Format(CultureInfo.InvariantCulture, "${0:F2}", x.Price))
			)
			.ForMember(
				dest => dest.Description,
				src => src.MapFrom(x => "asd")
			);

		this.CreateMap<ProductDTO, ProductItemViewModel>()
			.ForMember(
				dest => dest.Price,
				src => src.MapFrom(
					x => string.Format(CultureInfo.InvariantCulture, "${0:F2}", x.Price))
			);
	}
}
