﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Core.Model
{
    public class MovieCastModel
    {
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string Character { get; set; }

        public virtual MovieResponseModel Movie { get; set; }
        public virtual CastModel Cast { get; set; }
    }
}
