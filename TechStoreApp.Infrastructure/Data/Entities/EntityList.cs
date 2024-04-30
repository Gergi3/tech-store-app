using System.Globalization;
using System.Text;

namespace TechStoreApp.Infrastructure.Data.Entities;
public class EntityList<T> : List<T>
{
	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();
		foreach (var item in this)
		{
			sb.Append(CultureInfo.InvariantCulture, $"{item}, ");
		}

		return string.Join(", ", this);
	}
}
