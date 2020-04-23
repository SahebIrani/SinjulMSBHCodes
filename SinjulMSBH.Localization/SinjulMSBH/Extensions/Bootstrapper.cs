using System.Collections.Generic;
using System.Globalization;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace SinjulMSBH.Localization.SinjulMSBH.Extensions
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddSinjulMSBHLocalization(this IServiceCollection services)
        {
            services
                .AddLocalization() // Default Path Resources .. !!!!   // SingleResxFile
                //.AddLocalization(_ => _.ResourcesPath = "Resources") // SingleResxFile
                //.AddLocalization(_ => _.ResourcesPath = "SinjulMSBH/Resources")
                .Configure<RequestLocalizationOptions>(
                    _ =>
                    {
                        List<CultureInfo> supportedCultures = new List<CultureInfo>
                        {
                            new CultureInfo("en-US"),
                            new CultureInfo("fa-IR")
                        };

                        _.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");

                        _.SupportedCultures = supportedCultures;
                        _.SupportedUICultures = supportedCultures;

                        _.RequestCultureProviders =
                            new[] { new RouteDataRequestCultureProvider { IndexOfCulture = 1, IndexofUICulture = 1 } };
                    })
                .Configure<RouteOptions>(options => options.ConstraintMap.Add("culture", typeof(LanguageRouteConstraint)))
            ;

            return services;
        }
        public static IApplicationBuilder UseSinjulMSBHLocalization(this IApplicationBuilder app)
        {
            IOptions<RequestLocalizationOptions> localizeOptions =
                app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();

            app.UseRequestLocalization(localizeOptions.Value);

            return app;
        }
    }
}
