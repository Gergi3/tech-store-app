using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Services;

public class ProductService : IProductService
{
	private readonly ICategoryService _categoryService;
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

	public async Task<List<ProductDTO>> TopRated(
		int count)
	{
		return await this._repo.AllReadonly<Product>()
			.Include(x => x.Reviews)
			.OrderByDescending(x => x.Reviews.Average(x => (decimal)x.Stars))
			.ThenByDescending(x => x.Reviews.Count)
			.Take(count)
			.ProjectTo<ProductDTO>(
				configuration: this._mapper.ConfigurationProvider,
				membersToExpand: [x => x.ReviewsCount, x => x.Reviews.Count])
			.ToListAsync();
	}

	public async Task<List<ProductDTO>> All(
		ProductQueryParams query,
		Guid userId)
	{
		var products = this._repo.AllReadonly<Product>();

		products = this.AllCategoryFiltered(products, query.CategorySlug);
		products = this.AllPriceFiltered(products, query.FromPrice, query.ToPrice);
		products = this.AllPageFiltered(products, query.Page, query.PerPage);

		return await products
			.ProjectTo<ProductDTO>(
				configuration: this._mapper.ConfigurationProvider,
				parameters: new { userId },
				membersToExpand: [x => x.Categories, x => x.ReviewsCount, x => x.Reviews.Count])
			.ToListAsync();
	}

	public async Task<Tuple<decimal, decimal>> GetMinAndMax(
		string? categorySlug)
	{
		var products = this._repo.AllReadonly<Product>();

		var productPrices = this.AllCategoryFiltered(products, categorySlug)
			.Select(x => x.Price)
			.DefaultIfEmpty();

		decimal min = await productPrices.MinAsync();
		decimal max = await productPrices.MaxAsync();

		return new Tuple<decimal, decimal>(min, max);
	}

	public async Task<ProductDTO?> GetBySlug(
		string slug,
		Guid userId = default)
	{
		if (slug == null)
		{
			throw new UnexpectedNullSlug();
		}

		return await this._repo
			.AllReadonly<Product>()
			.ProjectTo<ProductDTO>(
				configuration: this._mapper.ConfigurationProvider,
				parameters: new { userId },
				membersToExpand: [x => x.Categories, x => x.ExtraInfos, x => x.Reviews, x => x.ReviewsCount]
			)
			.FirstOrDefaultAsync(x => x.Slug == slug);
	}

	public async Task<string?> GetNameBySlug(
		string slug)
	{
		if (slug == null)
		{
			throw new UnexpectedNullSlug();
		}

		return await this._repo
			.AllReadonly<Product>()
			.Where(x => x.Slug == slug)
			.Select(x => x.Name)
			.FirstOrDefaultAsync();
	}

	public async Task<int> Count(
		ProductQueryParams query)
	{
		var products = this._repo.AllReadonly<Product>();

		products = this.AllCategoryFiltered(products, query.CategorySlug);
		products = this.AllPriceFiltered(products, query.FromPrice, query.ToPrice);

		return await products.CountAsync();
	}

	public async Task<bool> Exists(
		string slug)
	{
		if (slug == null)
		{
			throw new UnexpectedNullSlug();
		}

		return await this._repo
			.AllReadonly<Product>()
			.AnyAsync(x => x.Slug == slug);
	}

	private IQueryable<Product> AllPriceFiltered(
		IQueryable<Product> queryable,
		decimal? fromPrice,
		decimal? toPrice)
	{
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
		return queryable
			.Skip((page - 1) * perPage)
			.Take(perPage);
	}
}
