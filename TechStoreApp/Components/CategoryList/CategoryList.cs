using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Components.CategoryList;

public class CategoryList : BaseViewComponent
{
	private readonly ICategoryService _categoryService;
	private readonly IMapper _mapper;

	public CategoryList(ICategoryService categoryService, IMapper mapper)
	{
		this._categoryService = categoryService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync(
		CategoryQueryParamsDTO query,
		bool layout = true
	)
	{
		int categoriesCount = await this._categoryService.Count();

		var categoryDTOs = await this._categoryService
			.All(query);

		var categoryViewModels = this._mapper
			.Map<List<CategoryItemViewModel>>(categoryDTOs);

		return this.View(new CategoryListViewModel()
		{
			Items = categoryViewModels,
			AllCount = categoriesCount,
			Take = query.Take,
			Skip = query.Skip,
			Layout = layout
		});
	}
}
