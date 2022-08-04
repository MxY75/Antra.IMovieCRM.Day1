
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Core.Entity;
using IMovieCRM.Infrastructure.Data;

namespace IMovieCRM.Infrastructure.Repository
{
    public class MovieCastRepositoryAsync : BaseRepositoryAsync<MovieCast>, IMovieCastRepositoryAsync
    {
        IMovieCrmDBContext movieContext;

        public MovieCastRepositoryAsync(IMovieCrmDBContext _context) : base(_context)
        {
            movieContext = _context;
        }

        public async Task<IEnumerable<MovieCast>> GetAllByCastIdAsync(int castId)
        {
            //select * from MovieCast join Movie on MovieCast.CastId =3;
            return await movieContext.MovieCast.Include("Movie").Where(x => x.CastId == castId).ToArrayAsync();
        }

        public async Task<IEnumerable<MovieCast>> GetAllByMovieIdAsync(int movieId)
        {
            //select* from MovieCast join cast on MovieCast.MovieId = 3;
            return await movieContext.MovieCast.Include("Cast").Where(x => x.MovieId == movieId).ToArrayAsync();
        }
    }
}
