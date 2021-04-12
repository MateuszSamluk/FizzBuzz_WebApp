using FizzBuzz_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz_WebApp.Data
{
    public class NumberContext : DbContext
    {
        

        public NumberContext(DbContextOptions options) : base(options) { }
        public DbSet<Number> Number { get; set; }
    }
}
