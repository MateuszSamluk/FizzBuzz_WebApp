using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz_WebApp.Data;
using FizzBuzz_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FizzBuzz_WebApp.Pages
{
    public class DataBase_Last10Model : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        readonly NumberContext _context;

        public DataBase_Last10Model(ILogger<IndexModel> logger, NumberContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public IList<Number> Numbers { get; set; }
        public void OnGet()
        {
            Numbers = _context.Number.Where(p => p.Id <= 10).ToList();
        }
        
    }
}
