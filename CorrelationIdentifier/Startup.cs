
using System;

using CorrelationId;
using CorrelationId.DependencyInjection;
using CorrelationId.HttpClient;

using CorrelationIdentifier.Controllers;
using CorrelationIdentifier.SinjulMSBH;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace CorrelationIdentifier
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
            services.TryAddScoped<CorrelationIDs, CorrelationIDs>();

            services.AddHttpClient<IValuesApiClient, ValuesApiClient>("ValuesApiClient", client =>
            {
                client.BaseAddress = new Uri("https://localhost:5001/");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("User-Agent", "ValuesWebApi");
            });

            services.AddTransient<NoOpDelegatingHandler>();

            services.AddHttpClient();

            services.AddHttpClient("MyClient")
                .AddCorrelationIdForwarding() 
                    //? add the handler to attach the correlation ID to outgoing requests for this named client
                .AddHttpMessageHandler<NoOpDelegatingHandler>()
            ;

            //? Example of adding default correlation ID (using the GUID generator) services
            //? As shown here, options can be configured via the configure degelate overload
            services.AddDefaultCorrelationId(options =>
            {
                options.CorrelationIdGenerator = () => "Foo";
                options.AddToLoggingScope = true;
                options.EnforceHeader = true;
                options.IgnoreRequestHeader = false;
                options.IncludeInResponse = true;
                options.RequestHeader = "My-Custom-Correlation-Id";
                options.ResponseHeader = "X-Correlation-Id";
                options.UpdateTraceIdentifier = false;
            });

            //? Example of registering a custom correlation ID provider
            //services.AddCorrelationId().WithCustomProvider<DoNothingCorrelationIdProvider>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseCorrelationId();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
