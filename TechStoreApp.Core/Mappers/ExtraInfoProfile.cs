using AutoMapper;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Mappers;
public class ExtraInfoProfile : Profile
{
	public ExtraInfoProfile()
	{
		this.CreateMap<ExtraInfo, ExtraInfoDTO>();
	}
}
