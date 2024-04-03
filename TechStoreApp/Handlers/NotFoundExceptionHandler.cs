using Microsoft.AspNetCore.Diagnostics;
using TechStoreApp.Common.Exceptions;

namespace TechStoreApp.Handlers;

public class NotFoundExceptionHandler : IExceptionHandler
{
	public async ValueTask<bool> TryHandleAsync(
		HttpContext httpContext,
		Exception exception,
		CancellationToken cancellationToken)
	{
		if (exception.GetType().IsSubclassOf(typeof(EntityNotFoundException)))
		{
			httpContext.Response.StatusCode = 404;
			//await httpContext.Response.CompleteAsync();
			return true;
		}
		return false;
	}
}
