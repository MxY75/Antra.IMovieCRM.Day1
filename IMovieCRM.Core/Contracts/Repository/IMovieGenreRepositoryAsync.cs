using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Core.Entity;

namespace IMovieCRM.Core.Contracts.Repository
{
    public interface IMovieGenreRepositoryAsync : IRepositoryAsync<MovieGenre>
    {
        Task<IEnumerable<MovieGenre>> GetAllByGenreIdAsync(int genreId);
        Task<IEnumerable<MovieGenre>> GetAllByMovieIdAsync(int movieId);
        //test azure//
        
    }
}
