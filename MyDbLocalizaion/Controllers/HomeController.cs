using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;

using DbLocalizationProvider;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using MyDbLocalizaion.Models;
using MyDbLocalizaion.Resources;

namespace MyDbLocalizaion.Controllers
{
    //[Authorize(Roles = "Administrators")]
    public class HomeController : Controller
    {
        private readonly ILocalizationProvider _provider;
        private readonly ILogger _logger;

        public HomeController(ILocalizationProvider provider, IOptions<MvcOptions> options, ILogger<HomeController> logger)
        {
            _provider = provider;
            _logger = logger;

            var asms = GetAssemblies().Where(a => a.FullName.Contains("MyDbLocalizaion"));
        }

        private static IEnumerable<Assembly> GetAssemblies()
        {
            var list = new List<string>();
            var stack = new Stack<Assembly>();

            stack.Push(Assembly.GetEntryAssembly());

            do
            {
                var asm = stack.Pop();

                yield return asm;

                foreach (var reference in asm.GetReferencedAssemblies())
                    if (!list.Contains(reference.FullName))
                    {
                        stack.Push(Assembly.Load(reference));
                        list.Add(reference.FullName);
                    }
            }
            while (stack.Count > 0);
        }

        public IActionResult Index()
        {
            var u = ControllerContext.HttpContext.User?.Identity;

            var zz = _provider.GetStringByCulture(() => ResourcesForFallback.OnlyInInvariant, new CultureInfo("sv"));

            var en = _provider.GetStringByCulture(() => ResourcesForFallback.InSwedishAndEnglishInvariant, new CultureInfo("en"));
            var sv = _provider.GetStringByCulture(() => ResourcesForFallback.InSwedishAndEnglishInvariant, new CultureInfo("sv"));

            ViewData["TestString"] = _provider.GetString(() => Resources.Shared.CommonResources.Yes);
            return View();
        }

        public IActionResult Routes()
        {
            return View();
        }

        public IActionResult ForeignModel()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                                    new CookieOptions
                                    {
                                        Expires = DateTimeOffset.UtcNow.AddYears(1)
                                    }
                                   );

            return LocalRedirect(returnUrl);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
