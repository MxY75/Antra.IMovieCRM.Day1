using IMovieCRM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Core.Contracts.Service
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreModel>> GetAllGenresAsync();
        Task <GenreModel>GetGenreById(int id);

    }
}
