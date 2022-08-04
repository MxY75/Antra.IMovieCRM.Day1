using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Core.Entity;
using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace IMovieCRM.Infrastructure.Repository
{
   public class MovieGenreRepositoryAsyn : BaseRepositoryAsync<MovieGenre>, IMovieGenreRepositoryAsync
    {
        IMovieCrmDBContext movieContext;
        public MovieGenreRepositoryAsyn(IMovieCrmDBContext _context) : base(_context)
        {
            movieContext = _context;
        }

        public async Task<IEnumerable<MovieGenre>> GetAllByGenreIdAsync(int genreId)
        {
            //select * from MovieCast join Movie on MovieGenre.genreid = 3
            return await movieContext.MovieGenre.Include("Movie").Where(x => x.GenreId == genreId).ToArrayAsync();
        }

        public async Task<IEnumerable<MovieGenre>> GetAllByMovieIdAsync(int movieId)
        {
            return await movieContext.MovieGenre.Include("Genre").Where(x => x.MovieId == movieId).ToArrayAsync();
        }
    }
}
