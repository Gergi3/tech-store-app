using AutoMapper;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Mappers;

public class ReviewProfile : Profile
{
	public ReviewProfile()
	{
		this.CreateMap<Review, ReviewDTO>()
			.ForMember(
				opt => opt.Username,
				dest => dest.MapFrom(r => r.User.UserName));
	}
}
