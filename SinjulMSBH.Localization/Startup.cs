using System.Globalization;

using DbLocalizationProvider;
using DbLocalizationProvider.AdminUI.AspNetCore;
using DbLocalizationProvider.AdminUI.AspNetCore.Routing;
using DbLocalizationProvider.AspNetCore;
using DbLocalizationProvider.AspNetCore.ClientsideProvider.Routing;
using DbLocalizationProvider.Storage.SqlServer;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using SinjulMSBH.Localization.Data;
using SinjulMSBH.Localization.SinjulMSBH.Extensions;

namespace SinjulMSBH.Localization
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
            services.AddSinjulMSBHLocalization();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));


            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();


            services.AddControllersWithViews()
                .AddMvcLocalization()
            ;

            services.AddRazorPages();

            services.AddRouting();

            services.AddDbLocalizationProvider(_ =>
            {
                _.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

                _.FallbackCultures
                    .Try(new CultureInfo("fa"))
                    .Then(new CultureInfo("en"));
            });

            services.AddDbLocalizationProviderAdminUI(_ =>
            {
                _.ShowInvariantCulture = true;
                _.RootUrl = "/loc-admin-ui";
                //_.AuthorizedAdminRoles.Add("Admins");
                //_.AuthorizedEditorRoles.Add("Translators");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseSinjulMSBHLocalization();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseDbLocalizationProvider();
            app.UseDbLocalizationProviderAdminUI();
            app.UseDbLocalizationClientsideProvider(); //assuming that you like also Javascript


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDbLocalizationClientsideProvider(path: "/jsl01n"); // assuming that you are mapping on /jsl10n/...

                endpoints.MapControllers();
                endpoints.MapControllerRoute("default", "{culture:culture}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();

                endpoints.MapDbLocalizationAdminUI();
            });
        }
    }
}
