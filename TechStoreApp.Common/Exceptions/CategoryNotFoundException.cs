namespace TechStoreApp.Common.Exceptions;

public class CategoryNotFoundException : Exception
{
	public override string Message => "Category was not found when trying to access product's category shop page";
}
