using IMovieCRM.Core.Contracts.Service;
using IMovieCRM.Core.Entity;
using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Infrastructure.Service
{
    public class CastService : ICastService
    {
        ICastRepository castRepository;

        public CastService(ICastRepository _castRepository)
        {
            this.castRepository = _castRepository;
        }

        public async Task<IEnumerable<CastModel>> GetAllCasts()
        {
            var result = await castRepository.GelAllAsync();
        
            List<CastModel> casts = new List<CastModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    CastModel c = new CastModel();
                    c.Id = item.Id;
                    c.Name = item.Name;
                    c.Gender = item.Gender;
                    c.TmdbUrl = item.TmdbUrl;
                    c.ProfilePath = item.ProfilePath;
                    casts.Add(c);
                }
            }
            return casts;
        }

        public  Task<int> InsertCast(CastModel castModel)
        {
            Cast castEntity = new Cast();
           
            castEntity.Name = castModel.Name;
            castEntity.TmdbUrl = castModel.TmdbUrl;
            castEntity.Gender = castModel.Gender;
            castEntity.ProfilePath = castModel.ProfilePath;
            return  castRepository.InsertAsync(castEntity);    

        }

        public async Task<CastModel> GetCastByIdAsync(int id)
        {
            Cast entity= await castRepository.GetByIdAsync(id);
            if (entity != null) {
                CastModel cast = new CastModel() {
                    Id = entity.Id,
                Gender = entity.Gender,
                 Name = entity.Name,
                 TmdbUrl = entity.TmdbUrl,
                 ProfilePath = entity.ProfilePath
                };
                return cast;
            }
            return null;
           
        }


    }
}
