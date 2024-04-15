using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Core.Models.Params;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Services;

public class ReviewService : IReviewService
{
	private readonly IRepository _repo;
	private readonly IMapper _mapper;

	public ReviewService(
		IRepository repo,
		IMapper mapper)
	{
		this._repo = repo;
		this._mapper = mapper;
	}

	public async Task<bool> Exists(
		Guid userId,
		Guid productsId)
	{
		return await this._repo
			.AllReadonly<Review>()
			.AnyAsync(x => x.UserId == userId && x.ProductsId == productsId);
	}

	public async Task<ReviewDTO> Create(
		ReviewCreateParams query,
		Guid userId)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		var review = new Review()
		{
			Id = Guid.NewGuid(),
			ProductsId = query.ProductsId,
			Stars = query.Stars,
			Text = query.Text,
			UserId = userId
		};

		await this._repo.AddAsync(review);
		await this._repo.SaveChangesAsync();

		Review dbReview = await this._repo
			.AllReadonly<Review>()
			.Include(r => r.User)
			.FirstAsync(x => x.Id == review.Id);

		var reviewDTO = this._mapper.Map<ReviewDTO>(dbReview);
		return reviewDTO;
	}
}
