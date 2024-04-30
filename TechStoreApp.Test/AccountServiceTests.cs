using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Moq;
using TechStoreApp.Core.Models.Auth;
using TechStoreApp.Core.Services;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Test;

[TestFixture]
public class AccountServiceTests
{
	private AccountService _accountService;
	private Mock<UserManager<AppUser>> _mockUserManager;

	[SetUp]
	public void Setup()
	{
		// Arrange
		this._mockUserManager = new Mock<UserManager<AppUser>>(
			Mock.Of<IUserStore<AppUser>>(), null!, null!, null!, null!, null!, null!, null!, null!);

		this._accountService = new AccountService(this._mockUserManager.Object);
	}

	[Test]
	public async Task Create_Should_Return_IdentityResult_And_AppUser()
	{
		// Arrange
		var model = new RegisterViewModel
		{
			Email = "test@example.com",
			UserName = "testuser",
			Password = "password"
		};

		var user = new AppUser
		{
			Email = model.Email,
			UserName = model.UserName
		};

		this._mockUserManager.Setup(x => x.CreateAsync(It.IsAny<AppUser>(), model.Password))
						.ReturnsAsync(IdentityResult.Success)
						.Callback((AppUser u, string _) => u.Id = Guid.NewGuid());

		// Act
		var result = await this._accountService.Create(model);

		// Assert
		Assert.IsTrue(result.Item1.Succeeded);
		Assert.That(result.Item2.Email, Is.EqualTo(user.Email));
		Assert.That(result.Item2.UserName, Is.EqualTo(user.UserName));
	}

	[Test]
	public async Task Get_Should_Return_Null_When_User_Not_Found()
	{
		// Arrange
		var model = new LoginViewModel
		{
			Email = "nonexistent@example.com"
		};

		this._mockUserManager.Setup(x => x.FindByEmailAsync(model.Email))
						.ReturnsAsync((AppUser)null!);

		// Act
		var result = await this._accountService.Get(model);

		// Assert
		Assert.IsNull(result);
	}

	[Test]
	public void GetUserId_Should_Return_Default_Guid_When_ClaimsPrincipal_Null()
	{
		// Act
		var result = this._accountService.GetUserId(null);

		// Assert
		Assert.That(result, Is.EqualTo(default(Guid)));
	}

	[Test]
	public void GetUserId_Should_Return_Default_Guid_When_NameIdentifier_Claim_Not_Found()
	{
		// Arrange
		var userPrincipal = new ClaimsPrincipal();

		// Act
		var result = this._accountService.GetUserId(userPrincipal);

		// Assert
		Assert.That(result, Is.EqualTo(default(Guid)));
	}

	[Test]
	public void GetIsAuthenticated_Should_Return_False_When_ClaimsPrincipal_Null()
	{
		// Act
		var result = this._accountService.GetIsAuthenticated(null);

		// Assert
		Assert.IsFalse(result);
	}

	[Test]
	public void GetIsAuthenticated_Should_Return_False_When_Identity_Not_Authenticated()
	{
		// Arrange
		var userPrincipal = new ClaimsPrincipal(new ClaimsIdentity());

		// Act
		var result = this._accountService.GetIsAuthenticated(userPrincipal);

		// Assert
		Assert.IsFalse(result);
	}

	[Test]
	public void GetIsAuthenticated_Should_Return_True_When_Identity_Authenticated()
	{
		// Arrange
		var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, "1") }, "TestAuthenticationType");
		identity.AddClaim(new Claim(ClaimTypes.AuthenticationMethod, "TestAuthenticationMethod"));
		var userPrincipal = new ClaimsPrincipal(identity);

		// Act
		var result = this._accountService.GetIsAuthenticated(userPrincipal);

		// Assert
		Assert.IsTrue(result);
	}
}
