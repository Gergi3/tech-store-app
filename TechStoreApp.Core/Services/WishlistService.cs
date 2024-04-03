using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Services;

public class WishlistService : IWishlistService
{
	private readonly IRepository _repo;
	private readonly IMapper _mapper;
	public WishlistService(IRepository repo, IMapper mapper)
	{
		this._repo = repo;
		this._mapper = mapper;
	}
	public async Task<List<WishlistDTO>> GetByUserId(Guid userId)
	{
		var wishlist = await this._repo
			.AllReadonly<Wishlist>()
			.Include(w => w.Product)
			.Where(w => w.UserId == userId)
			.ToListAsync();

		var wishlistDTOs = this._mapper.Map<List<WishlistDTO>>(wishlist);

		return wishlistDTOs;
	}

	public async Task<bool> ChangeStatus(
		Guid userId,
		Guid productId)
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
			.AllReadonly<Wishlist>()
			.Where(w => w.UserId == userId && w.ProductId == productId)
			.ExecuteDeleteAsync();

		if (deleted != 0)
		{
			return true;
		}

		var wishlist = new Wishlist()
		{
			ProductId = productId,
			UserId = userId
		};

		await this._repo.AddAsync(wishlist);
		await this._repo.SaveChangesAsync();
		return false;
	}

	public async Task<bool> ExistsByProductAndUserIds(Guid productId, Guid userId)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		if (productId == default)
		{
			throw new UnexpectedNullProduct();
		}

		return await this._repo
			.AllReadonly<Wishlist>()
			.AnyAsync(w => w.ProductId == productId && w.UserId == userId);
	}

	public async Task<int> Count(Guid userId)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		return await this._repo
			.AllReadonly<Wishlist>()
			.CountAsync(w => w.UserId == userId);
	}

	public async Task<bool> EditQuantity(Guid productId, Guid currentUserId, int newQuantity)
	{
		int updatedRows = await this._repo.AllReadonly<Wishlist>()
			.Where(w => w.ProductId == productId && w.UserId == currentUserId)
			.ExecuteUpdateAsync(updater => updater.SetProperty(w => w.Quantity, newQuantity));

		return updatedRows != 0;
	}
}
