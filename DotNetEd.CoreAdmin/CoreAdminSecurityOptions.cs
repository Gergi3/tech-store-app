using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NonFactors.Mvc.Grid;

namespace DotNetEd.CoreAdmin;

public class CoreAdminOptions
{
	public string[] RestrictToRoles { get; set; }
	public Func<Task<bool>> CustomAuthorisationMethod { get; set; }
	public bool IsSecuritySet => (this.RestrictToRoles != null && this.RestrictToRoles.Length > 0) || this.CustomAuthorisationMethod != null || this.CustomAuthorisationMethodWithServiceProvider != null;

	public string CdnPath { get; set; }
	public Func<IServiceProvider, Task<bool>> CustomAuthorisationMethodWithServiceProvider { get; set; }
	public IEnumerable<Type> IgnoreEntityTypes { get; set; } = new List<Type>();
	public Dictionary<Int32, string> PageSizes { get; set; }
	public bool ShowPageSizes { get; set; }
	public GridFilterMode FilterMode { get; set; }
	public string Title { get; set; } = "Core Admin";

	public CoreAdminOptions()
	{
		this.PageSizes = new Dictionary<Int32, String> { { 0, "All" }, { 10, "10" }, { 20, "20" } };
		this.ShowPageSizes = true;
		this.FilterMode = GridFilterMode.Header;
	}
}
