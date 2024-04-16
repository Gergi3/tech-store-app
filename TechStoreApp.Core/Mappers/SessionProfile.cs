using AutoMapper;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Mappers;

public class SessionProfile : Profile
{
	public SessionProfile()
	{
		this.CreateMap<Session, SessionDTO>()
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
			)
			.ForMember(
				dest => dest.ImageUrl,
				opt => opt.MapFrom(w => w.Product.ImageUrl)
			);
	}
}
