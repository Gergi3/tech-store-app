using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Core.Models.Params;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;
using TechStoreApp.Infrastructure.Data.EnumTypes;

namespace TechStoreApp.Core.Services;

public class OrderService : IOrderService
{
	private readonly IRepository _repo;
	private readonly IMapper _mapper;
	private readonly ISessionService _sessionService;

	public OrderService(
		IRepository repo,
		IMapper mapper,
		ISessionService sessionService)
	{
		this._repo = repo;
		this._mapper = mapper;
		this._sessionService = sessionService;
	}

	public async Task Create(
		OrderParams orderParams,
		Guid userId)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		var total = await this._sessionService
			.GetTotal(userId, SessionStatus.InCart);

		List<SessionDTO> sessionItems = await this._sessionService
			.GetByUserId(userId, SessionStatus.InCart);

		var order = new Order()
		{
			Id = Guid.NewGuid(),
			Address = orderParams.Address,
			City = orderParams.City,
			CompanyName = orderParams.CompanyName,
			Country = orderParams.Country,
			FirstName = orderParams.FirstName,
			LastName = orderParams.LastName,
			OrderNotes = orderParams.OrderNotes,
			Phone = orderParams.Phone,
			Price = total,
			UserId = userId
		};

		foreach (var item in sessionItems)
			{
			order.OrderProducts.Add(new OrderProduct()
			{
				Quantity = item.Quantity,
				ProductsId = item.ProductId,
			});
		}

		await this._repo.AddAsync(order);
		await this._repo.SaveChangesAsync();

		await this._sessionService.Clear(userId, SessionStatus.InCart);
	}

	public async Task<List<OrderDTO>> All(
		Guid userId)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		return await this._repo
			.AllReadonly<Order>()
			.Where(o => o.UserId == userId)
			.ProjectTo<OrderDTO>(this._mapper.ConfigurationProvider)
			.ToListAsync();
	}
}
