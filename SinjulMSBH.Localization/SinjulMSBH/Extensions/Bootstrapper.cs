using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using SinjulMSBH.Localization.Resources;

namespace SinjulMSBH.Localization.SinjulMSBH.Extensions
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddSinjulMSBHLocalization(this IServiceCollection services)
        {
            services
                .AddControllersWithViews()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(_ =>
                {
                    _.DataAnnotationLocalizerProvider = (type, factory) =>
                    {
                        return factory.Create(typeof(Resource));

                        //AssemblyName assemblyName = 
                        //    new AssemblyName(typeof(Resource).GetTypeInfo().Assembly.FullName);

                        //return factory.Create("Translations", assemblyName.Name);
                    };
                })
            ;

            services
                //.AddLocalization(_ => _.ResourcesPath = "SinjulMSBH/Resources")
                //.AddLocalization(_ => _.ResourcesPath = "Resources") // SingleResxFile
                .AddLocalization() // Default Path Resources .. !!!!   // SingleResxFile
                .Configure<MvcDataAnnotationsLocalizationOptions>(_ =>
                {
                    _.DataAnnotationLocalizerProvider = (type, factory) =>
                        factory.Create(typeof(Resource));
                })
                .Configure<RequestLocalizationOptions>(
                    _ =>
                    {
                        List<CultureInfo> supportedCultures = new List<CultureInfo>
                        {
                            new CultureInfo("en-US"),
                            new CultureInfo("fa-IR"),
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
