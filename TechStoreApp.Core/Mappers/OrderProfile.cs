using AutoMapper;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Mappers;
public class OrderProfile : Profile
{
	public OrderProfile()
	{
		this.CreateMap<Order, OrderDTO>();
	}
}
