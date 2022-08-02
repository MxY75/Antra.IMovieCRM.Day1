using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Core.Entity
{
    public class MovieCast
    {


        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string Character { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Cast Cast { get; set; }
    }
}
