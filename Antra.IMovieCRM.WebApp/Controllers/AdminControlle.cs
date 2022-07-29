using Microsoft.AspNetCore.Mvc;

namespace Antra.IMovieCRM.WebApp.Controllers
{
    public class AdminControlle : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
