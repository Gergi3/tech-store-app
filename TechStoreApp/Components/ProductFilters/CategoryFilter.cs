using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.Params;
using TechStoreApp.Models.Components;
using static TechStoreApp.Common.QueryConstants.Category;

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
		var queryParams = new CategoryQueryParams()
		{
			Skip = DefaultSkipProductsPage,
			Take = DefaultTakeProductsPage
		};

		var categories = await this._categoryService
			.All(queryParams.Skip, queryParams.Take);

		var categoryViewModels = this._mapper
			.Map<List<CategoryFilterViewModel>>(categories);

		return this.View(categoryViewModels);
	}
}
