using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz_WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FizzBuzz_WebApp.Pages
{
    public class LastSearchModel : PageModel
    {
        public Number Number { get; set; }
        

        public string Feedback;
        public string Time;
        

        public void OnGet()
        {
            var SessionNumber = HttpContext.Session.GetString("SessionNumber");
            var SessionFeedback = HttpContext.Session.GetString("SessionFeedback");
            var SessionTime = HttpContext.Session.GetString("SessionTime");
            
            if (SessionNumber != null) Number = JsonConvert.DeserializeObject<Number>(SessionNumber);
            if (SessionFeedback != null) Feedback = JsonConvert.DeserializeObject<string>(SessionFeedback);
            if (SessionTime != null) Time = JsonConvert.DeserializeObject<string>(SessionTime);
            
        }
    }
}
