using TechStoreApp.Infrastructure.Data.EnumTypes;

namespace TechStoreApp.Models.Components;

public class SessionViewModel
{
	public SessionStatus Status { get; set; }
	public List<SessionItemViewModel> Items { get; set; } = [];
	public string TotalPrice { get; set; }
}
