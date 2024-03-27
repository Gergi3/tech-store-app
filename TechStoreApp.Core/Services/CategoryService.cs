using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Services;

public class CategoryService : ICategoryService
{
	private readonly IRepository _repo;
	private readonly IMapper _mapper;
	public CategoryService(IRepository repo, IMapper mapper)
	{
		this._repo = repo;
		this._mapper = mapper;
	}

	public async Task<List<CategoryDTO>> All(CategoryQueryParamsDTO query)
	{
		return await this._repo
			.AllReadonly<Category>()
			.Skip(query.Skip)
			.Take(query.Take)
			.ProjectTo<CategoryDTO>(this._mapper.ConfigurationProvider)
			.ToListAsync();
	}

	public async Task<int> Count()
	{
		return await this._repo
			.AllReadonly<Category>()
			.CountAsync();
	}

	public async Task<string?> GetDbNameBySlug(string categorySlug)
	{
		return await this._repo
			.AllReadonly<Category>()
			.Where(x => x.Slug == categorySlug.ToLower())
			.Select(x => x.Name)
			.FirstOrDefaultAsync();
	}
}
