using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie18.Models;

namespace RazorPagesMovie18.Data
{
    public class RazorPagesMovie18Context : DbContext
    {
        public RazorPagesMovie18Context (DbContextOptions<RazorPagesMovie18Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie18.Models.Movie> Movie { get; set; }
    }
}
