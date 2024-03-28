namespace TechStoreApp.Common;
public static class ConfigConstants
{
	public static readonly string ConnectionStringName = "TechStoreAppConnectionString";

	public static readonly string[] AdditionalViewLocationFormats = ["/Views/{1}/{0}/{0}"];

	public static readonly string ErrorHandlerPageRoute = "/Home/Error";

	public static readonly string CoreAdminTitle = "Tech Store CMS";

	public static readonly string CoreAdminUrl = "admin";

	public static readonly string HostName = "AppHost";
}
