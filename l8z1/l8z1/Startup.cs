using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l8z1
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
            services.AddControllersWithViews();
            services.AddMvc()
            .AddSessionStateTempDataProvider();
            services.AddSession();
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
                endpoints.MapControllerRoute(
                    name: "MP",
                    pattern: "Home/MP",
                    defaults: new { controller = "Home", action = "MyPage" });

                endpoints.MapControllerRoute(
                    name: "MP2",
                    pattern: "MP/{number}/{name},{other}",
                    defaults: new { controller = "Home", action = "MyPage2" });

                endpoints.MapControllerRoute(
                    name: "Solve",
                    pattern: "Tool/Solve/{a}/{b}/{c}",
                    defaults: new { controller = "Tool", action = "Solve" });

                endpoints.MapControllerRoute(
                    name: "inputRange",
                    pattern: "Set,{number}",
                    defaults: new { controller = "Game", action = "Set" }
               );


                endpoints.MapControllerRoute(
                    name: "generateNumber",
                    pattern: "Draw",
                    defaults: new { controller = "Game", action = "Draw" }
               );

                endpoints.MapControllerRoute(
                    name: "guess",
                    pattern: "Guess,{guess}",
                    defaults: new { controller = "Game", action = "Guess" }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
