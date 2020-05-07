using System;
using System.Globalization;

using DbLocalizationProvider;
using DbLocalizationProvider.AspNetCore;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;

namespace MyDbLocalizaion.Controllers
{
    public class SinjulMSBHController : Controller
    {
        public SinjulMSBHController(
            LocalizationProvider localizationProvider,
            ILocalizationProvider provider,
            IStringLocalizer<ResourcesForSinjulMSBH> stringLocalizer,
            IHtmlLocalizer<ResourcesForSinjulMSBH> htmlLocalizer)
        {
            LocalizationProvider = localizationProvider ?? throw new ArgumentNullException(nameof(localizationProvider));
            Provider = provider ?? throw new ArgumentNullException(nameof(provider));
            StringLocalizer = stringLocalizer ?? throw new ArgumentNullException(nameof(stringLocalizer));
            HtmlLocalizer = htmlLocalizer ?? throw new ArgumentNullException(nameof(htmlLocalizer));
        }

        public LocalizationProvider LocalizationProvider { get; }
        public ILocalizationProvider Provider { get; }
        public IStringLocalizer StringLocalizer { get; }
        public IHtmlLocalizer<ResourcesForSinjulMSBH> HtmlLocalizer { get; }

        public IActionResult Index()
        {
            string lp = LocalizationProvider
                .GetString("MyDbLocalizaion.ResourcesForSinjulMSBH.Jackslater")
            ;

            string gs = Provider.GetString(()
                => ResourcesForSinjulMSBH.Jackslater);
            string gsc = Provider.GetStringByCulture(()
                => ResourcesForSinjulMSBH.Jackslater, new CultureInfo("sv"));

            string gs2 = StringLocalizer.GetString(()
                => ResourcesForSinjulMSBH.Jackslater);
            string gsc2 = StringLocalizer.GetStringByCulture(()
                => ResourcesForSinjulMSBH.Jackslater, new CultureInfo("sv"));

            LocalizedHtmlString gs3 = HtmlLocalizer.GetString(c => c.TitleHeader);
            LocalizedHtmlString gsc3 =
                HtmlLocalizer.GetStringByCulture(c => c.TitleHeader, new CultureInfo("sv"));

            return View();
        }
    }
}
