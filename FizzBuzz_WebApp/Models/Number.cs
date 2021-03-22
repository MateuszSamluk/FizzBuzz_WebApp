using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz_WebApp.Models
{
    public class Number
    {
        [Display(Name = "Podaj liczbę z akresu 1-1000 ")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [Range(1,1000,ErrorMessage ="Podano liczbę spoza zakresu")]
        public int UserNumber { get; set; }

    }
}
