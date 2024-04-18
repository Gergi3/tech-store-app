using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Converters;
using TechStoreApp.Infrastructure.Data.Entities;
using static TechStoreApp.Common.SeedConstants.Category;

namespace TechStoreApp.Infrastructure.Data.Configuration;

internal class CategoryConfiguration
	: IEntityTypeConfiguration<Category>
{
	public void Configure(
		EntityTypeBuilder<Category> builder)
	{
		builder.HasMany(c => c.Products)
			.WithMany(p => p.Categories)
			.UsingEntity<ProductCategory>();

		builder.Property(c => c.Slug)
			.HasConversion(typeof(SlugValueConverter));

		builder.Property(c => c.ImageUrl)
			.HasDefaultValue("/img/product-default.png");

		builder.HasData(this.Seed());
	}

	public Category[] Seed()
	{
		Category[] categories =
		[
			new Category
			{
				Id = new Guid(LaptopsId),
				Name = "Laptops",
				Slug = "laptops",
				ImageUrl = "https://i.pinimg.com/originals/8b/ed/07/8bed07b0525de6c40cec2fd811fa783c.png"
			},
			new Category
			{
				Id = new Guid(SmartphonesId),
				Name = "Smartphones",
				Slug = "smartphones",
				ImageUrl = "https://png.pngtree.com/png-clipart/20220306/original/pngtree-iphone-template-elements-png-image_7402666.png"
			},
			new Category
			{
				Id = new Guid(TabletsId),
				Name = "Tablets",
				Slug = "tablets",
				ImageUrl = "https://www.pngall.com/wp-content/uploads/2016/05/Tablet-PNG-Images.png"
			},
			new Category
			{
				Id = new Guid(GamingConsolesId),
				Name = "Gaming Consoles",
				Slug = "gaming-consoles",
				ImageUrl = "https://www.pngall.com/wp-content/uploads/2/Console-PNG-Picture.png"
			},
			new Category
			{
				Id = new Guid(PCComponentsId),
				Name = "PC Components",
				Slug = "pc-components",
				ImageUrl = "https://www.geekdoor.com/images/inner-banner.png",
			},
			new Category
			{
				Id = new Guid(AudioEquipmentId),
				Name = "Audio Equipment",
				Slug = "audio-equipment",
				ImageUrl = "https://pngimg.com/d/audio_speakers_PNG11130.png"
			},
			new Category
			{
				Id = new Guid(CamerasId),
				Name = "Cameras",
				Slug = "cameras",
				ImageUrl = "https://pngimg.com/d/photo_camera_PNG101601.png"
			},
			new Category
			{
				Id = new Guid(WearableTechnologyId),
				Name = "Wearable Technology",
				Slug = "wearable-technology",
				ImageUrl = "https://pngimg.com/d/watches_PNG101449.png"
			},
			new Category
			{
				Id = new Guid(NetworkingDevicesId),
				Name = "Networking Devices",
				Slug = "networking-devices",
				ImageUrl = "https://purepng.com/public/uploads/large/purepng.com-routerelectronicsroutermodem-941524673117w8ovp.png"
			}
		];

		return categories;
	}
}
