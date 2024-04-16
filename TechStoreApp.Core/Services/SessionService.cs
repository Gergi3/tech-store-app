using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;
using TechStoreApp.Infrastructure.Data.EnumTypes;

namespace TechStoreApp.Core.Services;

public class SessionService : ISessionService
{
	private readonly IRepository _repo;
	private readonly IMapper _mapper;

	public SessionService(
		IRepository repo,
		IMapper mapper)
	{
		this._repo = repo;
		this._mapper = mapper;
	}
	public async Task<decimal> GetTotal(
		Guid userId,
		SessionStatus status)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		var total = await this._repo
			.AllReadonly<Session>()
			.Include(s => s.Product)
			.Where(s => s.Status == status && s.UserId == userId)
			.SumAsync(s => s.Product.Price * s.Quantity);

		return total;
	}

	public async Task<List<SessionDTO>> GetByUserId(
		Guid userId,
		SessionStatus status)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		var session = await this._repo
			.AllReadonly<Session>()
			.Include(s => s.Product)
			.Where(s => s.Status == status && s.UserId == userId)
			.ToListAsync();

		var sessionDTOs = this._mapper.Map<List<SessionDTO>>(session);

		return sessionDTOs;
	}

	public async Task<bool> ChangeStatus(
		Guid userId,
		Guid productId,
		SessionStatus status)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		if (productId == default)
		{
			throw new UnexpectedNullProduct();
		}

		int deleted = await this._repo
			.AllReadonly<Session>()
			.Where(s =>
				s.UserId == userId
				&& s.ProductId == productId
				&& s.Status == status)
			.ExecuteDeleteAsync();

		if (deleted != 0)
		{
			return true;
		}

		var session = new Session()
		{
			ProductId = productId,
			UserId = userId,
			Status = status
		};

		await this._repo.AddAsync(session);
		await this._repo.SaveChangesAsync();

		return false;
	}

	public async Task<int> Count(
		Guid userId,
		SessionStatus status)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		return await this._repo
			.AllReadonly<Session>()
			.CountAsync(s => s.UserId == userId && s.Status == status);
	}

	public async Task<bool> EditQuantity(
		Guid productId,
		Guid currentUserId,
		SessionStatus status,
		int newQuantity)
	{
		if (productId == default)
		{
			throw new UnexpectedNullProduct();
		}

		if (currentUserId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		int updatedRows = await this._repo
			.AllReadonly<Session>()
			.Where(s =>
				s.ProductId == productId
				&& s.UserId == currentUserId
				&& s.Status == status)
			.ExecuteUpdateAsync(updater => updater.SetProperty(w => w.Quantity, newQuantity));

		return updatedRows != 0;
	}

	public async Task Clear(Guid userId, SessionStatus status)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		await this._repo
			.AllReadonly<Session>()
			.Where(s =>
				s.UserId == userId
				&& s.Status == status)
			.ExecuteDeleteAsync();
	}
}
