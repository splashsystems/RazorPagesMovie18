using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie18.Data;
using RazorPagesMovie18.Models;

namespace RazorPagesMovie18.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie18.Data.RazorPagesMovie18Context _context;

        public IndexModel(RazorPagesMovie18.Data.RazorPagesMovie18Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
