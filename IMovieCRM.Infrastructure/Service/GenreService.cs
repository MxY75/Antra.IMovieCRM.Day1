using IMovieCRM.Core.Contracts.Service;
using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Infrastructure.Service
{
    public class GenreService : IGenreService
    {
        IGenreRepositoryAsync genreRepository;
        public GenreService(IGenreRepositoryAsync genreRepository)
        {
            this.genreRepository = genreRepository;
        }

        public async Task<IEnumerable<GenreModel>> GetAllGenresAsync()
        {
            var result = await genreRepository.GelAllAsync();
            List<GenreModel> geners = new List<GenreModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    var model = new GenreModel();
                    model.Name = item.Name;
                    model.Id = item.Id;
                    geners.Add(model);
                }
                return geners;
            }
            return null;
        }

        public async Task<GenreModel> GetGenreById(int id)
        {
            var entity = await genreRepository.GetByIdAsync(id);

            GenreModel model = new GenreModel();

            if(entity != null)
            {
                model.Id = entity.Id;
                model.Name = entity.Name;

                return model;
            }
            Console.WriteLine( "Genre is null");
            return null;
        }
    }
}
