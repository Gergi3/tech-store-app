﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetEd.CoreAdmin;

public class CoreAdminAuthAttribute : TypeFilterAttribute
{
	public CoreAdminAuthAttribute() : base(typeof(CoreAdminAuthFilter)) { }
}

public class CoreAdminAuthFilter : IAuthorizationFilter
{
	private readonly IWebHostEnvironment environment;
	private readonly IList<CoreAdminOptions> coreAdminOptions;
	private readonly IServiceProvider serviceProvider;

	public CoreAdminAuthFilter(IWebHostEnvironment environment, IEnumerable<CoreAdminOptions> securityOptions, IServiceProvider serviceProvider)
	{
		this.environment = environment;
		this.coreAdminOptions = securityOptions.ToList();
		this.serviceProvider = serviceProvider;
	}

	public async void OnAuthorization(AuthorizationFilterContext context)
	{

		bool failedSecurityCheck = true;

		// in Development mode, allow bypassing security (shows a warning message)
		if (this.environment.EnvironmentName == "Development" && !this.coreAdminOptions.Any(o => o.IsSecuritySet))
		{
			failedSecurityCheck = false;
		}
		else
		{
			foreach (var options in this.coreAdminOptions)
			{
				if (options.RestrictToRoles != null && options.RestrictToRoles.Any())
				{
					foreach (var role in options.RestrictToRoles)
					{
						if (context.HttpContext.User.IsInRole(role))
						{
							failedSecurityCheck = false;
						}
					}
				}

				if (options.CustomAuthorisationMethod != null)
				{
					if (await options.CustomAuthorisationMethod())
					{
						failedSecurityCheck = false;
					}
				}

				if (options.CustomAuthorisationMethodWithServiceProvider != null)
				{
					if (await options.CustomAuthorisationMethodWithServiceProvider(this.serviceProvider))
					{
						failedSecurityCheck = false;
					}
				}
			}
		}

		if (failedSecurityCheck)
		{
			context.Result = new UnauthorizedResult();
		}
	}
}