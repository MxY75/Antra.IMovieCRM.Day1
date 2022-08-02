﻿using IMovieCRM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Core.Contracts.Service
{
    public interface IMovieServiceAsync
    {
        Task<MovieResponseModel> GetByIdAsync(int id);
    }
}