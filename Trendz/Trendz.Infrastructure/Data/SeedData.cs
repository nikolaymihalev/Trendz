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
        }

        public IdentityUser Guest { get; set; } = null!;
        public IdentityUser BrandOwner { get; set; } = null!;
        public Brand Brand { get; set; } = null!;
        public Category MenTshirt { get; set; } = null!;
        public Category WomenTshirt { get; set; } = null!;
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
            MenTshirt = new Category()
            {
                Id = 1,
                Name = "Men T-Shirts",
                DateAdded = DateTime.Parse("17/06/2024")
            };

            WomenTshirt = new Category()
            {
                Id = 2,
                Name = "Women T-Shirts",
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
                Name = "M Size"
            };

            SSize = new Size()
            {
                Id = 2,
                Name = "S Size"
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
        }
    }
}
