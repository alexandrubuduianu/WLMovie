using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WLMovie.Models
{
    public class WLMovieContext : DbContext
    {
        public WLMovieContext (DbContextOptions<WLMovieContext> options)
            : base(options)
        {
        }

        public DbSet<WLMovie.Models.Movie> Movie { get; set; }
    }
}
