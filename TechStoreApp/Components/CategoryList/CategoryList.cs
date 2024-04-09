using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.Params;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.CategoryList;

public class CategoryList : BaseViewComponent
{
	private readonly ICategoryService _categoryService;
	private readonly IMapper _mapper;

	public CategoryList(
		ICategoryService categoryService,
		IMapper mapper)
	{
		this._categoryService = categoryService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync(
		CategoryQueryParams query,
		bool layout = true)
	{
		int categoriesCount = await this._categoryService.Count();

		var categoryDTOs = await this._categoryService.All(query.Skip, query.Take);

		var categoryViewModels = this._mapper
			.Map<List<CategoryItemViewModel>>(categoryDTOs);

		return this.View(new CategoryListViewModel()
		{
			Items = categoryViewModels,
			TotalCount = categoriesCount,
			Take = query.Take,
			Skip = query.Skip,
			Layout = layout
		});
	}
}
