using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CIS174Eddie.Models;
using Microsoft.EntityFrameworkCore;


namespace CIS174Eddie
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(60 * 5);
                options.Cookie.HttpOnly = false;
                options.Cookie.IsEssential = true;
            });
            services.AddControllersWithViews().AddNewtonsoftJson();

            // URL Slugs
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });

            services.AddDbContext<ContactContext>();
            services.AddDbContext<MovieContext>(); // Dependency injection for context object
            services.AddDbContext<CountryContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}/{slug?}");

                endpoints.MapControllerRoute(
                    name: "country",
                    pattern: "{controller}/{action}/{id?}/game/{activeGame}/cat/{activeCat}/{slug?}");

                endpoints.MapControllerRoute(
                    name: "custom",
                    pattern: "{controller}/{action}/{id?}/item{num}/{slug?}");

                endpoints.MapControllerRoute(
                    name: "access",
                    pattern: "{controller}/{action}/lvl{lvl}/{slug?}"); // This route handles access levels

                endpoints.MapControllerRoute(
                    name: "details",
                    pattern: "{controller}/{action}/{id}/{slug?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}"); // Added slug

            });
        }
    }
}
