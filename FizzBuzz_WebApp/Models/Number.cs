using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz_WebApp.Models
{
    public class Number
    {
        public int Id { get; set; }

        [Display(Name = "Podaj liczbę z zakresu 1-1000 ")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [Range(1,1000,ErrorMessage ="Podano liczbę spoza zakresu")]
        public int UserNumber { get; set; }
      

    }
}
