using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Trendz.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
