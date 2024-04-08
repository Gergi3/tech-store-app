using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
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

	public ProductService(IRepository repo, IMapper mapper,
		ICategoryService categoryService)
	{
		this._repo = repo;
		this._mapper = mapper;
		this._categoryService = categoryService;
	}

	public async Task<List<ProductDTO>> All(ProductQueryParamsDTO query)
	{
		var products = this._repo.AllReadonly<Product>();

		products = this.AllCategoryFiltered(products, query.CategorySlug);
		products = this.AllPriceFiltered(products, query.FromPrice, query.ToPrice);
		products = this.AllPageFiltered(products, query.Page, query.PerPage);

		return await products
			.ProjectTo<ProductDTO>(
				configuration: this._mapper.ConfigurationProvider,
				parameters: new { userId = query.CurrentUserId })
			.ToListAsync();
	}

	public async Task<Tuple<decimal, decimal>> GetMinAndMax(ProductQueryParamsDTO query)
	{
		var products = this._repo.AllReadonly<Product>();

		products = this.AllCategoryFiltered(products, query.CategorySlug);

		var productPrices = products
			.Select(x => x.Price)
			.DefaultIfEmpty();

		decimal min = await productPrices.MinAsync();
		decimal max = await productPrices.MaxAsync();

		return new Tuple<decimal, decimal>(min, max);
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
		var products = this._repo.AllReadonly<Product>();

		products = this.AllCategoryFiltered(products, query.CategorySlug);
		products = this.AllPriceFiltered(products, query.FromPrice, query.ToPrice);

		return await products.CountAsync();
	}

	private IQueryable<Product> AllPriceFiltered(
		IQueryable<Product> queryable,
		decimal? fromPrice,
		decimal? toPrice)
	{
		queryable = queryable ?? this._repo.AllReadonly<Product>();

		if (fromPrice != null)
		{
			queryable = queryable.Where(x => x.Price >= fromPrice);
		}

		if (toPrice != null)
		{
			queryable = queryable.Where(x => x.Price <= toPrice);
		}

		return queryable;
	}

	private IQueryable<Product> AllCategoryFiltered(
		IQueryable<Product> queryable,
		string? categorySlug)
	{
		queryable = queryable ?? this._repo.AllReadonly<Product>();

		if (categorySlug != null)
		{
			return queryable
				.Include(x => x.Categories)
				.Where(x => x.Categories.Any(x => x.Slug == categorySlug));
		}

		return queryable;
	}

	private IQueryable<Product> AllPageFiltered(
		IQueryable<Product> queryable,
		int page,
		int perPage)
	{
		if (page <= 0)
		{
			page = DefaultFirstPage;
		}

		if (perPage <= 0)
		{
			perPage = DefaultPerPage;
		}

		queryable = queryable ?? this._repo.AllReadonly<Product>();

		return queryable
			.Skip((page - 1) * perPage)
			.Take(perPage);
	}
}
