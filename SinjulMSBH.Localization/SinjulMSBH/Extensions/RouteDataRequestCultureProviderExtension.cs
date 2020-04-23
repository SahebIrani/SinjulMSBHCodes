using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace SinjulMSBH.Localization.SinjulMSBH.Extensions
{
    public class RouteDataRequestCultureProvider : RequestCultureProvider
    {
        public int IndexOfCulture;
        public int IndexofUICulture;

        public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            if (httpContext == null) throw new ArgumentNullException(nameof(httpContext));

            string uiCulture, culture = uiCulture =
                httpContext.Request.Path.Value.Split('/')[IndexOfCulture]?.ToString();

            ProviderCultureResult providerResultCulture = new ProviderCultureResult(culture, uiCulture);

            return Task.FromResult(providerResultCulture);
        }
    }
}
