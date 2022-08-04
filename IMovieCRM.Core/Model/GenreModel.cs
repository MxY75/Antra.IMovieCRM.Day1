using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMovieCRM.Core.Model
{
   public class GenreModel
    {

        public int Id { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }

        public virtual IEnumerable<MovieGenreModel> MovieGenres { get; set; }
    }
}
