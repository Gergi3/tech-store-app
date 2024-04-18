using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.HomeCategoryList;

public class HomeCategoryList : BaseViewComponent
{
	private readonly ICategoryService _categoryService;
	private readonly IMapper _mapper;

	public HomeCategoryList(
		ICategoryService categoryService,
		IMapper mapper)
	{
		this._categoryService = categoryService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		var categoryDTOs = await this._categoryService.AllMostPopular(5);

		var viewModels = this._mapper.Map<List<HomeCategoryItemViewModel>>(categoryDTOs);

		return this.View(viewModels);
	}
}
