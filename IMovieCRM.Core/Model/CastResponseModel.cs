using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Core.Entity;

namespace IMovieCRM.Core.Model
{
    public class CastResponseModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Character { get; set; }
        public string Gender { get; set; }
        public string ProfilePath { get; set; }
        public virtual IEnumerable<MovieCastModel> MovieCasts { get; set; }
    }
}
