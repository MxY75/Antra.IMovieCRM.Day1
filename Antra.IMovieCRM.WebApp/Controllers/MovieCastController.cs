using IMovieCRM.Core.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace Antra.IMovieCRM.WebApp.Controllers
{
    public class MovieCastController : Controller
    {
        IMovieCastServiceAsync movieCastService;
        public MovieCastController(IMovieCastServiceAsync _movieCastServiceAsync ) { 
              movieCastService = _movieCastServiceAsync;   
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AllMoviesListByCastId(int cid) {
            var result = await movieCastService.GetAllByCastId(cid);
            return View(result);
        }
    }
}
