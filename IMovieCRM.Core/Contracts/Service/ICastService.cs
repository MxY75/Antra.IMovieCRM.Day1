using IMovieCRM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Core.Contracts.Service
{
    public interface ICastService
    {

        Task<int> InsertCast(CastModel castModel);
        Task<IEnumerable<CastModel>> GetAllCasts();
        Task<CastModel> GetCastByIdAsync(int id);
    }
}
