 using IMovieCRM.Core.Contracts.Service;
using IMovieCRM.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace Antra.IMovieCRM.WebApp.Controllers
{
    public class CastController : Controller
    {
        ICastService castService;
        IMovieCastServiceAsync movieCastServiceAsync;

        public CastController(ICastService castService, IMovieCastServiceAsync movieCastServiceAsync)
        {
            this.castService = castService;
            this.movieCastServiceAsync = movieCastServiceAsync; 
        }

        public async Task<IActionResult> Index()
        {
            var result = await castService.GetAllCasts();
            return View(result);
        }

        //post is to send data

        [HttpGet]
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CastModel model) {
            if (ModelState.IsValid) {
                await castService.InsertCast(model);
            }
            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id) {
            CastModel model = await castService.GetCastByIdAsync(id);
            model.MovieCasts = await movieCastServiceAsync.GetAllByCastId(id);
            return View(model);
        }
    }
}
