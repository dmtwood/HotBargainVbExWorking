using System;
using HotBargainVbEx.Data;
using HotBargainVbEx.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(HotBargainVbEx.Areas.Identity.IdentityHostingStartup))]
namespace HotBargainVbEx.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<HotBargainVbExContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("HotBargainVbExContextConnection")));

                services.AddDefaultIdentity<Personeel>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<HotBargainVbExContext>();
            });
        }
    }
}