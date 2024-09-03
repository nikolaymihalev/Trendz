using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using Trendz.Core.Contracts;
using Trendz.Models;

namespace Trendz.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICartService cartService;
        private readonly IFavoriteProductService favoriteProductService;
        private readonly IProductService productService;
        private readonly IDiscountService discountService;

        public HomeController(
            ILogger<HomeController> logger,
            ICartService _cartService,
            IFavoriteProductService _favoriteProductService,
            IProductService _productService,
            IDiscountService _discountService)
        {
            _logger = logger;
            cartService = _cartService;
            favoriteProductService = _favoriteProductService;
            productService = _productService;
            discountService = _discountService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Cart()
        {
            try
            {
                var model = await cartService.GetByUserIdAsync(User.Id());

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Home.Cart");

                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public async Task<IActionResult> FavoriteProducts() 
        {
            var model = await favoriteProductService.GetUserFavoriteProductsAsync(User.Id());

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Products(string category, string sorting, int currentPage = 1) 
        {
            var model = await productService.GetProductsForPageAsync(category, sorting, currentPage);

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Recommended(string category, string sorting, int currentPage = 1)
        {
            var model = await productService.GetProductsForPageAsync(category, sorting, currentPage);
            
            var allProd = await productService.GetAllProductsAsync();

            model.Products = await productService.GetProductsWithHighestRatingAsync(allProd.Count());

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Discount(decimal percentage) 
        {
            var model = await discountService.GetDiscountsPerPercentageAsync(percentage);

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
