using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Core.Contracts.Service;
using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Core.Model;

namespace IMovieCRM.Infrastructure.Service
{
    public class MovieCastService :IMovieCastServiceAsync
    {
        IMovieCastRepositoryAsync mctRepositoryAsync;
        public MovieCastService(IMovieCastRepositoryAsync _mctRepositoryAsync)
        {
            this.mctRepositoryAsync = _mctRepositoryAsync;
        }

        public async Task<IEnumerable<MovieCastModel>> GetAllByMovieId(int id)
        {
          var result = await mctRepositoryAsync.GetAllByMovieIdAsync(id);
            List<MovieCastModel> mcLst = new List<MovieCastModel>();

            foreach(var mc in result) {
                MovieCastModel model = new MovieCastModel();
                model.CastId = mc.CastId;
                model.Character = mc.Character;
                model.Cast = new CastModel()
                {
                    Id = mc.Cast.Id,
                    Gender = mc.Cast.Gender,
                    Name = mc.Cast.Name,
                    ProfilePath = mc.Cast.ProfilePath,
                    TmdbUrl = mc.Cast.TmdbUrl
                };
                mcLst.Add(model);
            }
            return mcLst;

        }
    }
}
