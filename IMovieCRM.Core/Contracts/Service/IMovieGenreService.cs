using IMovieCRM.Core.Entity;
using IMovieCRM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Core.Contracts.Service
{
    public interface IMovieGenreService
    {
        Task<IEnumerable<MovieGenreModel>> GetAllByGenreIdAsync(int genreId);
        Task<IEnumerable<MovieGenreModel>> GetAllByMovieIdAsync(int movieId);
    }
}
