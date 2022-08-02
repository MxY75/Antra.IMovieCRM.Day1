using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Core.Entity;
using IMovieCRM.Core.Model;
using IMovieCRM.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Infrastructure.Repository
{
    public class MovieRepositoryAsync : BaseRepositoryAsync<Movie>,IMovieRepositoryAsync
    {
        public MovieRepositoryAsync(IMovieCrmDBContext _context) : base(_context)
        {
        }

     
     }
}
