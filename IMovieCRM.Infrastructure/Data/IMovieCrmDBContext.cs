using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovieCRM.Core.Entity;


namespace IMovieCRM.Infrastructure.Data
{

    //walk with database 
    //dapper connect to database 

    // DbContext instace reprecent a session with the database 
    //connect to db and write in db 
    public  class IMovieCrmDBContext :DbContext 
    {

        //Why we are doing it connection string in mvc objct 
        // and movie is in infastructuer so we need to pass it into infastructre obj
        //but infastructure i
        public IMovieCrmDBContext(DbContextOptions<IMovieCrmDBContext> options) : base(options) { 
        }

        public DbSet<Cast> Cast { get; set; }
        public DbSet<Genre> Genre { get; set; }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<MovieCast> MovieCast { get; set; }

    }
}
