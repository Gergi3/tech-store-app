using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Components.ProductFilters;

public class CategoryFilter : BaseViewComponent
{
	private readonly ICategoryService _categoryService;
	private readonly IMapper _mapper;

	public CategoryFilter(
		ICategoryService categoryService,
		IMapper mapper)
	{
		this._categoryService = categoryService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		var queryParams = new CategoryQueryParamsDTO()
		{
			Skip = 0,
			Take = 20
		};

		var categories = await this._categoryService.All(queryParams);

		var categoryViewModels = this._mapper.Map < List<CategoryFilterViewModel>>(categories);

		return this.View(categoryViewModels);
	}
}
