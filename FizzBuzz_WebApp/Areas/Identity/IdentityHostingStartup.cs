using System;
using FizzBuzz_WebApp.Areas.Identity.Data;
using FizzBuzz_WebApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FizzBuzz_WebApp.Areas.Identity.IdentityHostingStartup))]
namespace FizzBuzz_WebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FizzBuzz_WebAppDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FizzBuzz_WebAppDBContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.SignIn.RequireConfirmedAccount = false;
                })
                    .AddEntityFrameworkStores<FizzBuzz_WebAppDBContext>();
            });
        }
    }
}