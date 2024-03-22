using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.Core.Models.Components;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Services;

public class ProductService : IProductService
{
	public readonly ICategoryService _categoryService;
	private readonly IRepository _repo;
	private readonly IMapper _mapper;

	public ProductService(
		IRepository repo,
		IMapper mapper,
		ICategoryService categoryService)
	{
		this._repo = repo;
		this._mapper = mapper;
		this._categoryService = categoryService;
	}

	public async Task<List<ProductDTO>> All(ProductQueryParamsDTO query)
	{
		var productsQueryable = this._repo
			.AllReadonly<Product>()
			.Include(x => x.Categories)
			.AsQueryable();

		if (query.CategoryName != null)
		{
			productsQueryable = productsQueryable
				.Where(x => x.Categories
					.Any(x => x.Name == query.CategoryName));
		}

		return await productsQueryable
			.ProjectTo<ProductDTO>(this._mapper.ConfigurationProvider)
			.ToListAsync();
	}

	public async Task<List<BreadcrumbItemViewModel>> ConstructBreadcrumb(
		ProductQueryParamsDTO query
	)
	{
		List<BreadcrumbItemViewModel> breadcrumb = [
			new()
			{
				Name = "Home",
				Path = ("Home", "Index")
			},
			new()
			{
				Name = "Products",
			}
		];

		string? categoryName = query.CategoryName;

		if (categoryName != null)
		{
			string? dbName = await this._categoryService.GetDbName(categoryName);
			if (dbName == null)
			{
				throw new CategoryNotFoundException();
			}

			breadcrumb.Add(new()
			{
				Name = dbName
			});
		}

		return breadcrumb;
	}
}
