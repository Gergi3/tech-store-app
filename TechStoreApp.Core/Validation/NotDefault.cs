using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Core.Validation;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public class NotDefault : ValidationAttribute
{
	public NotDefault()
		: base("The {0} field requires a non-default value.")
	{
	}

	public override bool IsValid(
		object? value)
	{
		if (value == null)
		{
			return true;
		}

		var type = value.GetType();
		var realType = Nullable.GetUnderlyingType(type) ?? type;
		var defaultValue = Activator.CreateInstance(realType);

		var isDefault = Equals(value, defaultValue);
		return !isDefault;
	}
}
