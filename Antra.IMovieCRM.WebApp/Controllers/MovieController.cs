
using IMovieCRM.Core.Contracts.Service;
using IMovieCRM.Core.Model;
using Microsoft.AspNetCore.Mvc;


namespace Antra.IMovieCRM.WebApp.Controllers
{
    public class MovieController : Controller
    {
        IGenreService genreService;
        IMovieGenreService movieGenreService;
        public MovieController(IGenreService genreService, IMovieGenreService movieGenreService)
        {
            this.genreService = genreService;
            this.movieGenreService = movieGenreService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> MovieByGenre(int id)
        {
            GenreModel model = await genreService.GetGenreById(id);
            model.MovieGenres = await movieGenreService.GetAllByGenreIdAsync(id);

            return View(model);
        }

        public async Task<IActionResult> MovieByGenrePage(int id, int pageSize = 30, int pageNumber = 1)
        {
            GenreModel model = await genreService.GetGenreById(id);
            model.MovieGenres = await movieGenreService.GetAllByGenreIdAsync(id);


            return View(model);
        }

    }
}
