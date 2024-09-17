using Microsoft.AspNetCore.Identity;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data
{
    internal class SeedData
    {
        public SeedData()
        {
            SeedUsers();
            SeedBrands();
            SeedCategories();
            SeedCarts();
            SeedWishlists();
            SeedProducts();
            SeedImages();
            SeedColors();
            SeedSizes();
            SeedProductColors();
            SeedProductSizes();
            SeedCoupons();
            SeedRatings();
            SeedReviews();
            SeedDiscounts();
            SeedFavoriteProducts();
            SeedInventoryItems();
        }

        public IdentityUser Guest { get; set; } = null!;
        public IdentityUser BrandOwner { get; set; } = null!;
        public Brand Brand { get; set; } = null!;
        public Category Men { get; set; } = null!;
        public Category Women { get; set; } = null!;
        public Cart Cart { get; set; } = null!;
        public Wishlist Wishlist { get; set; } = null!;
        public Product BlackTshirt { get; set; } = null!;
        public ProductImage BlackTshirtFirstImage { get; set; } = null!;
        public ProductImage BlackTshirtSecondImage { get; set; } = null!;
        public Color Black { get; set; } = null!;
        public Color White { get; set; } = null!;
        public Size MSize { get; set; } = null!;
        public Size SSize { get; set; } = null!;
        public ProductColor ProductColorBlack { get; set; } = null!;
        public ProductColor ProductColorWhite { get; set; } = null!;
        public ProductSize ProductSizeM { get; set; } = null!;
        public ProductSize ProductSizeS { get; set; } = null!;
        public Coupon Coupon { get; set; } = null!;
        public Coupon Coupon20 { get; set; } = null!;
        public Rating FiveStar { get; set; } = null!;
        public Review FiveStarReview { get; set; } = null!;
        public Discount Discount20 { get; set; } = null!;
        public FavoriteProduct FavoriteProduct { get; set; } = null!;
        public Inventory BlackTshirtSInStock { get; set; } = null!;
        public Inventory BlackTshirtMInStock { get; set; } = null!;

        private void SeedUsers() 
        {
            var hasher = new PasswordHasher<IdentityUser>();

            Guest = new IdentityUser()
            {
                Id = "bd68a836-f988-4dea-af8d-ad33664480af",
                UserName = "Guest",
                NormalizedUserName = "GUEST",
                Email = "guest@gmail.com",
                NormalizedEmail = "GUEST@GMAIL.COM"
            };

            BrandOwner = new IdentityUser()
            {
                Id = "98e1c54e-cc2b-4c09-8678-b0fba336e522",
                UserName = "Brand Owner",
                NormalizedUserName = "BRAND OWNER",
                Email = "owner@gmail.com",
                NormalizedEmail = "OWNER@GMAIL.COM"
            };

            Guest.PasswordHash = hasher.HashPassword(Guest, "guest1234");
            BrandOwner.PasswordHash = hasher.HashPassword(BrandOwner, "owner1234");
        }

        private void SeedBrands() 
        {
            Brand = new Brand()
            {
                Id = 1,
                Name = "Nike",
                DateAdded = DateTime.Parse("17/06/2024")
            };
        }

        private void SeedCategories() 
        {
            Men = new Category()
            {
                Id = 1,
                Name = "Men",
                DateAdded = DateTime.Parse("17/06/2024")
            };

            Women = new Category()
            {
                Id = 2,
                Name = "Women",
                DateAdded = DateTime.Parse("17/06/2024")
            };
        }

        private void SeedCarts()
        {
            Cart = new Cart()
            {
                Id = 1,
                UserId = Guest.Id,
                DateCreated = DateTime.Parse("17/06/2024")
            };
        }

        private void SeedWishlists() 
        {
            Wishlist = new Wishlist()
            {
                Id = 1,
                UserId = Guest.Id,
                DateCreated = DateTime.Parse("17/06/2024")
            };
        }

        private void SeedProducts() 
        {
            BlackTshirt = new Product()
            {
                Id = 1,
                Name = "T-Shirt Regular Fit",
                Description = "T-shirt in lightweight cotton jersey with a round neck with ribbed hems and a straight hem. With a standard cut for comfortable wear and a classic silhouette.",
                Price = 9.99m,
                CategoryId = 1,
                BrandId = 1,
                DateAdded = DateTime.Parse("17/06/2024")
            };
        }

        private void SeedImages()
        {
            BlackTshirtFirstImage = new ProductImage()
            {
                Id = 1,
                ProductId = 1,
                Image = File.ReadAllBytes(Path.Combine(@"Images", "firstimage.png")),
            };

            BlackTshirtSecondImage = new ProductImage()
            {
                Id = 2,
                ProductId = 1,
                Image = File.ReadAllBytes(Path.Combine(@"Images", "secondimage.png")),
            };
        }

        private void SeedColors() 
        {
            Black = new Color()
            {
                Id = 1,
                Name = "Black",
                HexValue = "#000000"
            };

            White = new Color()
            {
                Id = 2,
                Name = "White",
                HexValue = "#fff"
            };
        }

        private void SeedSizes() 
        {
            MSize = new Size()
            {
                Id = 1,
                Name = "M"
            };

            SSize = new Size()
            {
                Id = 2,
                Name = "S"
            };
        }

        private void SeedProductColors() 
        {
            ProductColorBlack = new ProductColor()
            {
                ProductId = 1,
                ColorId = 1
            };

            ProductColorWhite = new ProductColor()
            {
                ProductId = 1,
                ColorId = 2
            };
        }

        private void SeedProductSizes()
        {
            ProductSizeM = new ProductSize()
            {
                ProductId = 1,
                SizeId = 1
            };

            ProductSizeS = new ProductSize()
            {
                ProductId = 1,
                SizeId = 2
            };
        }

        private void SeedCoupons() 
        {
            Coupon = new Coupon()
            {
                Id = 1,
                Percentage = 50m,
                Image = File.ReadAllBytes(Path.Combine(@"Images", "coupon.png"))
            };

            Coupon20 = new Coupon()
            {
                Id = 2,
                Percentage = 20m,
                Image = File.ReadAllBytes(Path.Combine(@"Images", "coupon-20.png"))
            };
        }

        private void SeedRatings()
        {
            FiveStar = new Rating()
            {
                Id = 1,
                UserId = Guest.Id,
                ProductId = BlackTshirt.Id,
                Value = 5.0
            };
        }

        private void SeedReviews() 
        {
            FiveStarReview = new Review()
            {
                Id = 1,
                ProductId = BlackTshirt.Id,
                UserId = Guest.Id,
                RatingId = FiveStar.Id,
                Comment = "Super cute for a party. True to size, it's a bit thin but still good quality, felt super comfortabcomfortable.",
                PublishDate = DateTime.Parse("11/08/2024")
            };
        }

        private void SeedDiscounts()
        {
            Discount20 = new Discount()
            {
                Id = 1,
                ProductId = BlackTshirt.Id,
                DiscountPercentage = 20m,
                StartDate = DateTime.Parse("12 August 2024"),
                EndDate = DateTime.Parse("23 December 2032")
            };
        }

        private void SeedFavoriteProducts()
        {
            FavoriteProduct = new FavoriteProduct()
            {
                Id = 1,
                ProductId = BlackTshirt.Id,
                UserId = Guest.Id
            };
        }

        private void SeedInventoryItems() 
        {
            BlackTshirtMInStock = new Inventory()
            {
                Id = 1,
                ProductId = BlackTshirt.Id,
                SizeId = MSize.Id,
                QuantityInStock = 3
            };

            BlackTshirtSInStock = new Inventory()
            {
                Id = 2,
                ProductId = BlackTshirt.Id,
                SizeId = SSize.Id,
                QuantityInStock = 5
            };
        }
    }
}
