using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FizzBuzz_WebApp.Data;
using FizzBuzz_WebApp.Models;

namespace FizzBuzz_WebApp.Pages.Numbers
{
    public class CreateModel : PageModel
    {
        private readonly FizzBuzz_WebApp.Data.NumberContext _context;

        public CreateModel(FizzBuzz_WebApp.Data.NumberContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Number Number { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Number.Add(Number);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
