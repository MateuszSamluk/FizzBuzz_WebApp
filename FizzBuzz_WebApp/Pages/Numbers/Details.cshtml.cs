using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FizzBuzz_WebApp.Data;
using FizzBuzz_WebApp.Models;

namespace FizzBuzz_WebApp.Pages.Numbers
{
    public class DetailsModel : PageModel
    {
        private readonly FizzBuzz_WebApp.Data.NumberContext _context;

        public DetailsModel(FizzBuzz_WebApp.Data.NumberContext context)
        {
            _context = context;
        }

        public Number Number { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Number = await _context.Number.FirstOrDefaultAsync(m => m.Id == id);

            if (Number == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
