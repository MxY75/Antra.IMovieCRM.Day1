using Microsoft.AspNetCore.Mvc;

namespace Antra.IMovieCRM.WebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
