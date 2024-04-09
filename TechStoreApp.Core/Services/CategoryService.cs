using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Services;

public class CategoryService : ICategoryService
{
	private readonly IRepository _repo;
	private readonly IMapper _mapper;

	public CategoryService(
		IRepository repo,
		IMapper mapper)
	{
		this._repo = repo;
		this._mapper = mapper;
	}

	public async Task<List<CategoryDTO>> All(
		int skip,
		int take)
	{
		return await this._repo
			.AllReadonly<Category>()
			.Skip(skip)
			.Take(take)
			.ProjectTo<CategoryDTO>(this._mapper.ConfigurationProvider)
			.ToListAsync();
	}

	public async Task<int> Count()
	{
		return await this._repo
			.AllReadonly<Category>()
			.CountAsync();
	}

	public async Task<string?> GetNameBySlug(
		string slug)
	{
		if (slug == null)
		{
			throw new UnexpectedNullSlug();
		}

		return await this._repo
			.AllReadonly<Category>()
			.Where(x => x.Slug == slug)
			.Select(x => x.Name)
			.FirstOrDefaultAsync();
	}

	public async Task<bool> TryExists(
		string? slug)
	{
		if (slug == null)
		{
			return true;
		}

		return await this._repo
			.AllReadonly<Category>()
			.AnyAsync(x => x.Slug == slug);
	}
}
