using DadJoke.Interfaces;
using DadJoke.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DadJoke
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //Register DadJoke service
            services.AddScoped<IDadJokeService, DadJokeService>();

            //Register configuration to read appsettings
            services.AddSingleton<IConfiguration>(Configuration);

            //For MVC
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            //For css and js files
            app.UseStaticFiles();

            //Default routing
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=DadJoke}/{action=DadJokeIndex}/");
            });
        }
    }
}
