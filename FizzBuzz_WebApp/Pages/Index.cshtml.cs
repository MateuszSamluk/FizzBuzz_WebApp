using FizzBuzz_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using FizzBuzz_WebApp.Data;
using System.Linq;

namespace FizzBuzz_WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Number Number { get; set; }
        public string Feedback;
        public DateTime SessionTime = DateTime.Now;//.ToString();
        private NumberContext _context;


        public IndexModel(ILogger<IndexModel> logger, NumberContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Number> Numbers { get; set; }
        public void OnGet()
        {
            //Numbers = _context.Number.ToList();
        }

        
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Number.UserNumber % 3 == 0) Feedback = "Otrzymano: Fizz";
                if (Number.UserNumber % 5 == 0) Feedback = "Otrzymano: Buzz";
                if (Number.UserNumber % 5 == 0 & Number.UserNumber % 3 == 0) Feedback = "Otrzymano: FizzBuzz";
                if (Feedback == null) Feedback = ($"Liczba {Number.UserNumber} nie spełnia kryteriów Fizz/Buzz");

                HttpContext.Session.SetString("SessionNumber", JsonConvert.SerializeObject(Number));
                HttpContext.Session.SetString("SessionFeedback", JsonConvert.SerializeObject(Feedback));
                HttpContext.Session.SetString("SessionTime", JsonConvert.SerializeObject(SessionTime));

               
                _context.Number.Add(Number);
                _context.SaveChanges();
                //return RedirectToPage("./LastSearch");


            }
            return Page();
        }
        
    }
}
