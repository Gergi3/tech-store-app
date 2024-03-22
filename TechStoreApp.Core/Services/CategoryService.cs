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

	public async Task<List<CategoryDTO>> All(int take = 3, int skip = 0)
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

	public async Task<bool> ExistsByName(string categoryName)
	{
		return await this._repo
			.AllReadonly<Category>()
			.AnyAsync(x => x.Name == categoryName);
	}

	public async Task<string?> GetDbName(string categoryName)
	{
		return await this._repo
			.AllReadonly<Category>()
			.Select(x => x.Name)
			.Where(x => x.ToLower() == categoryName.ToLower())
			.FirstOrDefaultAsync();
	}
}
