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

        public HomeController(
            ILogger<HomeController> logger,
            ICartService _cartService)
        {
            _logger = logger;
            cartService = _cartService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
