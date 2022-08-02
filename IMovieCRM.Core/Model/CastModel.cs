using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IMovieCRM.Core.Model
{
  public class CastModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Cast Name is required ")]
        [MaxLength(50,ErrorMessage ="Region Name can be maximum 128 character Long")]
        public string Name { get; set; }
        public string Gender { get; set; }

        public string TmdbUrl { get; set; }
        public string ProfilePath { get; set; }
    }
}
