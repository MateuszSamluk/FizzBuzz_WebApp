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
    public class IndexModel : PageModel
    {
        private readonly FizzBuzz_WebApp.Data.NumberContext _context;

        public IndexModel(FizzBuzz_WebApp.Data.NumberContext context)
        {
            _context = context;
        }

        public IList<Number> Number { get;set; }

        public async Task OnGetAsync()
        {
            Number = await _context.Number.ToListAsync();
        }
    }
}
