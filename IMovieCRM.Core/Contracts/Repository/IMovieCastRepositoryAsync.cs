using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Core.Entity;

namespace IMovieCRM.Core.Contracts.Repository
{
   public interface IMovieCastRepositoryAsync : IRepositoryAsync<MovieCast>
    {
        Task<IEnumerable<MovieCast>> GetAllByMovieIdAsync(int movieId);
        Task<IEnumerable<MovieCast>> GetAllByCastIdAsync(int castId);
    }
}
