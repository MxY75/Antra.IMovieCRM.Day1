using Microsoft.AspNetCore.Mvc;

namespace Antra.IMovieCRM.WebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
