using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;

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
		int skip,
		int take,
		bool layout = true
	)
	{
		int allCount = await this._categoryService.Count();

		List<CategoryDTO> categoryDTOs = await this._categoryService
			.All(take, skip);

		var categoryViewModels = this._mapper
			.Map<List<CategoryItemViewModel>>(categoryDTOs);

		return this.View(new CategoryListViewModel()
		{
			Items = categoryViewModels,
			AllCount = allCount,
			Take = take,
			Skip = skip,
			Layout = layout
		});
	}
}
