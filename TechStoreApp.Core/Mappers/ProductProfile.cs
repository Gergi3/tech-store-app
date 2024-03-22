using AutoMapper;
using TechStoreApp.Core.Models;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Mappers;
public class ProductProfile : Profile
{
	public ProductProfile()
	{
		this.CreateProjection<Product, ProductDTO>();
	}
}
