using IMovieCRM.Core.Entity;
using IMovieCRM.Core.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Infrastructure.Data;

namespace IMovieCRM.Infrastructure.Repository
{
    public class GenreRepositoryAsyn : BaseRepositoryAsync<Genre>, IGenreRepositoryAsync
    {
        public GenreRepositoryAsyn(IMovieCrmDBContext _context) : base(_context)
        {
        }
    }
}
