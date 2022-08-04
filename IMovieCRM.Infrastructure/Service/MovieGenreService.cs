using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Core.Contracts.Service;
using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Core.Model;
using IMovieCRM.Core.Entity;

namespace IMovieCRM.Infrastructure.Service
{

    public class MovieGenreService : IMovieGenreService
    {
        IMovieGenreRepositoryAsync movieGenreRepositoryAsync;
        public MovieGenreService(IMovieGenreRepositoryAsync movieGenreRepositoryAsync)
        {
            this.movieGenreRepositoryAsync = movieGenreRepositoryAsync;
        }

        public async  Task<IEnumerable<MovieGenreModel>> GetAllByGenreIdAsync(int genreId)
        {
            var result = await movieGenreRepositoryAsync.GetAllByGenreIdAsync(genreId);
            List<MovieGenreModel> mgLst = new List<MovieGenreModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    MovieGenreModel model = new MovieGenreModel();
                    model.MovieId = item.MovieId;
                    model.GenreId = item.GenreId;
                    model.Movie = new MovieResponseModel()
                    {

                        Id = item.MovieId,
                        Title = item.Movie.Title,
                        Overview = item.Movie.Overview,
                        Tagline = item.Movie.Tagline,
                        PosterUrl = item.Movie.PosterUrl,
                        ReleaseDate = item.Movie.ReleaseDate
                    };

                    mgLst.Add(model);
                }
                return mgLst;
            }
            Console.WriteLine("MovieGenre is null");
            return null;
        }

        public async  Task<IEnumerable<MovieGenreModel>> GetAllByMovieIdAsync(int movieId)
        {
            var result = await movieGenreRepositoryAsync.GetAllByMovieIdAsync(movieId);
            List<MovieGenreModel> mgLst = new List<MovieGenreModel>();
            if (result != null)
            {
                foreach (var item in result)
                {

                    MovieGenreModel model = new MovieGenreModel();
                    model.MovieId = item.MovieId;
                    model.GenreId = item.GenreId;
                    model.Genre = new GenreModel
                    {

                        Id = item.Genre.Id,
                        Name = item.Genre.Name
                    };
                    mgLst.Add(model);
                }

                return mgLst;
            }
            return null;
        }
    }
}
