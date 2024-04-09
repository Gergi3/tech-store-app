namespace TechStoreApp.Common.Exceptions;

public class CategoryNotFoundException : EntityNotFoundException
{
	public override string Message => "Category was not found.";
}
