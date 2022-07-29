using Microsoft.AspNetCore.Mvc;

namespace Antra.IMovieCRM.WebApp.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
