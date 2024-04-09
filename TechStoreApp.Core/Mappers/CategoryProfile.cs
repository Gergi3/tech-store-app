using AutoMapper;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Mappers;

public class CategoryProfile : Profile
{
	public CategoryProfile()
	{
		this.CreateMap<Category, CategoryDTO>()
			.ForMember(
				dest => dest.Count,
				src => src.MapFrom(x => x.Products.Count())
			);
	}
}
