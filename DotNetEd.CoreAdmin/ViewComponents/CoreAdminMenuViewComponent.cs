using System.Collections.Generic;
using DotNetEd.CoreAdmin.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetEd.CoreAdmin.ViewComponents;

public class CoreAdminMenuViewComponent : ViewComponent
{
	private readonly IEnumerable<DiscoveredDbSetEntityType> dbSetEntities;

	public CoreAdminMenuViewComponent(IEnumerable<DiscoveredDbSetEntityType> dbContexts)
	{
		this.dbSetEntities = dbContexts;
	}

	public IViewComponentResult Invoke()
	{
		var viewModel = new MenuViewModel();

		foreach (var dbSetEntity in this.dbSetEntities)
		{
			viewModel.DbContextNames.Add(dbSetEntity.DbContextType.Name);
			viewModel.DbSetNames.Add(dbSetEntity.Name);
		}

		return this.View(viewModel);
	}
}
