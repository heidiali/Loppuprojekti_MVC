using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Loppuprojekti_MVC.Models;
using System.Web.Mvc;
using System.Security.Policy;
using System.Web;
using System.Globalization;

namespace Loppuprojekti_MVC
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

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddJsonLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc().AddViewLocalization();
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // HERE WE NEED SOMETHING ELSE THAT POINTS TO THE API
            services.AddDbContext<Loppuprojekti_MVCContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("Loppuprojekti_MVCContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var cultureInfo = new CultureInfo("fi-FI");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "Species",
                    template: "{controller=Species}/{action=SpeciesIndex}");
                routes.MapRoute(
                    name: "SingleSpecies",
                    template: "{controller=Species}/{action=SingleSpecies}");
                routes.MapRoute(
                    name: "FirstLetterSearch",
                    template: "{controller=Country}/{action=CountryIndex}/{firstLetter?}");
                routes.MapRoute(
                    name: "Countries",
                    template: "{controller=Country}/{action=CountryIndex}");
                routes.MapRoute(
                    name: "ENSpecies",
                    template: "{controller=Country}/{action=ENSpecies}");
                routes.MapRoute(
                    name: "Map",
                    template: "{controller=Map}/{action=Country}");
                routes.MapRoute(
                   name: "Resources",
                   template: "{controller=Resources}/{action=ResourcesIndex}");
                routes.MapRoute(
                   name: "Bubble",
                   template: "{controller=Bubble}/{action=Bubble}");
                
            });
    }
    } }
