using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorIdentity.Areas.Identity.Data;
using RazorIdentity.Models;

namespace RazorIdentity.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorIdentity.Areas.Identity.Data.RazorIdentityContextDb _context;

        public IndexModel(RazorIdentity.Areas.Identity.Data.RazorIdentityContextDb context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
