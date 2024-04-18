using AutoMapper;
using TechStoreApp.Common.Extensions;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Mappers;

public class ViewComponentsProfile : Profile
{
	public ViewComponentsProfile()
	{
		this.CreateMap<CategoryDTO, CategoryFilterViewModel>();
		this.CreateMap<CategoryDTO, CategoryItemViewModel>();
		this.CreateMap<CategoryDTO, ProductItemCategoriesViewModel>();
		this.CreateMap<CategoryDTO, ProductDetailsCategoriesViewModel>();
		this.CreateMap<CategoryDTO, HomeCategoryItemViewModel>();
		this.CreateMap<ExtraInfoDTO, ExtraInfoViewModel>();
		this.CreateMap<ReviewDTO, ReviewViewModel>();

		this.CreateMap<SessionDTO, SessionItemViewModel>()
			.ForMember(
				dest => dest.Price,
				src => src.MapFrom(
					x => x.Price.ToPriceString())
			)
			.ForMember(
				dest => dest.PriceForAll,
				src => src.MapFrom(
					x => (x.Price * x.Quantity).ToPriceString())
			);

		this.CreateMap<ProductDTO, ProductDetailsTopViewModel>()
			.ForMember(
				dest => dest.Price,
				src => src.MapFrom(
					x => x.Price.ToPriceString())
			);

		this.CreateMap<ProductDTO, ProductItemViewModel>()
			.ForMember(
				dest => dest.Price,
				src => src.MapFrom(
					x => x.Price.ToPriceString())
			);
	}
}
