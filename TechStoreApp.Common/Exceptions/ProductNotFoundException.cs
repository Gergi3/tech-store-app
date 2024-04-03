namespace TechStoreApp.Common.Exceptions;
public class ProductNotFoundException : EntityNotFoundException
{
	public override string Message => "Product was not found when trying to access product's details page";

}
