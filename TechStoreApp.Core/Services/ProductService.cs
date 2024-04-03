using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;
using static TechStoreApp.Common.QueryConstants.Product;

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
		if (query.Page <= 0)
		{
			query.Page = DefaultFirstPage;
		}

		if (query.PerPage <= 0)
		{
			query.PerPage = DefaultPerPage;
		}

		var productsQueryable = this.AllAsQueryable(query)
			.Skip((query.Page - 1) * query.PerPage)
			.Take(query.PerPage);

		return await productsQueryable
			.ProjectTo<ProductDTO>(
				configuration: this._mapper.ConfigurationProvider,
				parameters: new { userId = query.CurrentUserId })
			.ToListAsync();
	}

	public async Task<ProductDTO?> GetBySlug(string slug)
	{
		return await this._repo
			.AllReadonly<Product>()
			.ProjectTo<ProductDTO>(this._mapper.ConfigurationProvider)
			.FirstOrDefaultAsync(x => x.Slug == slug);
	}

	public async Task<string?> GetNameBySlug(string productSlug)
	{
		return await this._repo
			.AllReadonly<Product>()
			.Where(x => x.Slug == productSlug)
			.Select(x => x.Name)
			.FirstOrDefaultAsync();
	}

	public async Task<int> Count(ProductQueryParamsDTO query)
	{
		return await
			this.AllAsQueryable(query)
			.CountAsync();
	}


	private IQueryable<Product> AllAsQueryable(ProductQueryParamsDTO query)
	{
		var productsQueryable = this._repo
			.AllReadonly<Product>()
			.Include(x => x.Categories)
			.AsQueryable();

		if (query.CategorySlug != null)
		{
			productsQueryable = productsQueryable
				.Where(x => x.Categories
					.Any(x => x.Slug == query.CategorySlug));
		}

		return productsQueryable;
	}
}
