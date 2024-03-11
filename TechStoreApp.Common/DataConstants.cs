namespace TechStoreApp.Common;
public static class DataConstants
{
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

	public static class SqlServerTypes
	{
		public const string MoneyType = "money";
	}
}
