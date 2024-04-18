namespace TechStoreApp.Common;
public static class DataConstants
{
	// language = regex, ExplicitCapture
	public const string WildRegex = @"(.*?)";

	public static class Category
	{
		public const int MinNameLength = 2;
		public const int MaxNameLength = 100;
	}

	public static class Product
	{
		public const int MinNameLength = 5;
		public const int MaxNameLength = 200;
	}

	public static class User
	{
		public const string AdminRole = "Admin";

		public const string AdminRoleId = "2358dc72-4280-40da-8986-4cf0cb4988ea";
		public const string AdminId = "05cb6d59-1d3d-4759-bd33-2378d9d9e689";

		public const bool RequireUniqueEmail = true;
		public const bool RequireConfirmedAccount = false;
		public const bool RequireConfirmedPhoneNumber = false;
		public const bool RequireConfirmedEmail = false;

		public const bool RequireUppercase = true;
		// language = regex, ExplicitCapture
		public const string RequireUppercaseRegex = RequireUppercase
			? @"(?=.*[A-Z]).*"
			: WildRegex;

		public const bool RequireLowercase = true;
		// language = regex, ExplicitCapture
		public const string RequireLowercaseRegex = RequireLowercase
			? @"(?=.*[a-z])"
			: WildRegex;

		public const bool RequireNonAlphanumeric = true;
		// language = regex, ExplicitCapture
		public const string RequireNonAlphanumericRegex = RequireNonAlphanumeric
			? "(?=.*[^0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz])"
			: WildRegex;

		public const bool RequireDigit = true;
		// language = regex, ExplicitCapture
		public const string RequireDigitRegex = RequireDigit
			? @"(?=.*\d)"
			: WildRegex;

		public const string PasswordRegex = @$"^{RequireDigitRegex}{RequireUppercaseRegex}{RequireNonAlphanumericRegex}{RequireDigitRegex}.*$";

		// language = regex, ExplicitCapture
		public const string UserNameRegex = @"^[a-zA-Z0-9_]{3,100}$";
		public const string UserNameErrorMessage =
			$"Username can only contain letters or digits and must be between 3 and 100 characters long";

		public const string PasswordRegexErrorMessage =
			$"Your password must have at least:\n" +
			$"{(RequireDigit ? "    1 digit\n" : "")}" +
			$"{(RequireNonAlphanumeric ? "    1 non-alphanumerical character\n" : "")}" +
			$"{(RequireLowercase ? "    1 lowercase character\n" : "")}" +
			$"{(RequireUppercase ? "    1 uppercase character" : "")}";

		public const int MinPasswordLength = 6;
		public const int MaxPasswordLength = 100;
	}
	public static class SqlServerTypes
	{
		public const string MoneyType = "money";
	}
}
