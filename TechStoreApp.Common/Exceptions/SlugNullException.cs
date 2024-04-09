namespace TechStoreApp.Common.Exceptions;

public class SlugNullException : EntityNotFoundException
{
	public override string Message => "Unexpected null reference. Slug was null when expected to be non-null";
}
