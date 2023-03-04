using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie_LR0_Tovstokor.Data
{
    public class MvcMovie_LR0_TovstokorContext : DbContext
    {
        public MvcMovie_LR0_TovstokorContext (DbContextOptions<MvcMovie_LR0_TovstokorContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
