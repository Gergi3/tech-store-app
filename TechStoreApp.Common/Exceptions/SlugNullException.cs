namespace TechStoreApp.Common.Exceptions;
public class SlugNullException : Exception
{
	public override string Message => "Unexpected null reference. Slug was null when expected to be non-null";
}
