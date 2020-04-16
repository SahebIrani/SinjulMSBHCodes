
using ChooseFreePort.SinjulMSBH;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ChooseFreePort
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
            => services.AddRazorPages().AddRazorRuntimeCompilation();
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env,
            IHostApplicationLifetime lifetime,
            ILogger<Startup> logger)
        {
            // Register a callback to run after the app is fuly configured
            lifetime.ApplicationStarted.Register(
              () => LogAddresses(app.ServerFeatures, logger));

            // other config

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                // Create the address endpoint, consisting of our middleware
                RequestDelegate addressEndpoint = endpoints
                    .CreateApplicationBuilder()
                    .UseMiddleware<ServerAddressesMiddleware>()
                    .Build();

                // Register the endpoint
                endpoints.MapGet("/addresses", addressEndpoint);
            });
        }


        // Called after configuration is complete
        static void LogAddresses(IFeatureCollection features, ILogger logger)
        {
            IServerAddressesFeature addressFeature = features.Get<IServerAddressesFeature>();
            // Do something with the addresses
            foreach (string address in addressFeature.Addresses)
                logger.LogInformation("Listening on address: " + address);
        }
    }
}
