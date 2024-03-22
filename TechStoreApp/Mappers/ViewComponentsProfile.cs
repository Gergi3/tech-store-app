using System.Globalization;
using AutoMapper;
using TechStoreApp.Components.CategoryList;
using TechStoreApp.Components.ProductList;
using TechStoreApp.Core.Models;

namespace TechStoreApp.Mappers;

public class ViewComponentsProfile : Profile
{
	public ViewComponentsProfile()
	{
		this.CreateMap<CategoryDTO, CategoryItemViewModel>();
		this.CreateMap<CategoryDTO, ProductItemCategoriesViewModel>();

		this.CreateMap<ProductDTO, ProductItemViewModel>()
			.ForMember(
				dest => dest.Price,
				src => src.MapFrom(
					x => string.Format(CultureInfo.InvariantCulture, "${0:F2}", x.Price))
			);
	}
}
