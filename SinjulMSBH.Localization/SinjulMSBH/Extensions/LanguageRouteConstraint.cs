using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace SinjulMSBH.Localization.SinjulMSBH.Extensions
{
    public class LanguageRouteConstraint : IRouteConstraint
    {
        public bool Match(
            HttpContext httpContext,
            IRouter route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            if (!values.ContainsKey("culture")) return false;

            string culture = values["culture"].ToString();

            return culture == "en-US" || culture == "fa-IR";
        }
    }
}
