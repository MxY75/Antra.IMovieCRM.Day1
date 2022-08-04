using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Core.Model
{
    public class MovieGenreModel
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public MovieResponseModel Movie { get; set; }
        public GenreModel Genre { get; set; }
    }
}
