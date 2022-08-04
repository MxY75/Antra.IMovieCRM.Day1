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

    public class CastRepository : BaseRepositoryAsync<Cast>, ICastRepository
    {
        public CastRepository(IMovieCrmDBContext _context) : base(_context)
        {
        }

    }
}