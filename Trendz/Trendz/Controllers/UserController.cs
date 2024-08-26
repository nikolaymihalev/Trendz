using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Trendz.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        
        public UserController(
            UserManager<IdentityUser> _userManager,
            SignInManager<IdentityUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
    }
}
