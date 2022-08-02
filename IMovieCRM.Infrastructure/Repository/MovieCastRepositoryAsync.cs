using IMovieCRM.Core.Entity;
using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IMovieCRM.Infrastructure.Repository
{
    internal class MovieCastRepositoryAsync : BaseRepositoryAsync<MovieCast>, IMovieCastRepositoryAsync
    {
        IMovieCrmDBContext movieContext;

        public MovieCastRepositoryAsync(IMovieCrmDBContext _context) : base(_context)
        {
        }

        public async Task<IEnumerable<MovieCast>> GetAllByMovieIdAsync(int movieId)
        {
            return await movieContext.MovieCast.Include("Cast").Where(x => x.MovieId == movieId).ToArrayAsync();
        }
    }
}
