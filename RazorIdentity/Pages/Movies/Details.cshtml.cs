﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly RazorIdentity.Areas.Identity.Data.RazorIdentityContextDb _context;

        public DetailsModel(RazorIdentity.Areas.Identity.Data.RazorIdentityContextDb context)
        {
            _context = context;
        }

      public Movie Movie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
