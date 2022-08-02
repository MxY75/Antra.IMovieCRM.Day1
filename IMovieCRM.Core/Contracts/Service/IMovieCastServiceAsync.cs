using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Core.Model;

namespace IMovieCRM.Core.Contracts.Service
{
    public interface IMovieCastServiceAsync
    {
    Task<IEnumerable<MovieCastModel>> GetAllByMovieId(int id);
    }
}
