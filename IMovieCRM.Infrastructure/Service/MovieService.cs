using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Core.Contracts.Service;
using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Core.Model;

namespace IMovieCRM.Infrastructure.Service
{
    public class MovieService : IMovieServiceAsync
    {

        IMovieRepositoryAsync movieRepositoryAsync;

        public MovieService(IMovieRepositoryAsync _movieRepositoryAsync) {
            movieRepositoryAsync = _movieRepositoryAsync;
        }
        public async Task<MovieResponseModel> GetByIdAsync(int id)
        {
            MovieResponseModel model = new MovieResponseModel();
            var movie = await movieRepositoryAsync.GetByIdAsync(id);
            if (movie != null) {
                model.Id = movie.Id;
                model.Overview = movie.Overview;
                model.PosterUrl = movie.PosterUrl;
                model.Title = movie.Title;
                model.Tagline = movie.Tagline;
                model.ReleaseDate = movie.ReleaseDate;

            }
            return model;
        }
    }
}
