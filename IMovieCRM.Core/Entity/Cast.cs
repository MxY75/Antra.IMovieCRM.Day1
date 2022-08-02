using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace IMovieCRM.Core.Entity
{
    public class Cast
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Gender { get; set; }

       [Column(TypeName = "varchar(124)")]
        public string TmdbUrl { get; set; }
        //using System.ComponentModel.DataAnnotations;
        //using System.ComponentModel.DataAnnotations.Schema;
        //can specify column name and type 

        public string ProfilePath { get; set; }
    }
}
