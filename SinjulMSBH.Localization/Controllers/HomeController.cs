
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

using SinjulMSBH.Localization.SinjulMSBH.Resources;

namespace SinjulMSBH.Localization.Controllers
{
    [ApiController, Route("{culture:culture}/[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController(
            ILogger<HomeController> logger,
            IStringLocalizer<HomeController> localizer,
            IStringLocalizer<SampleResources> stringLocalizer)
        {
            _logger = logger;
            Localizer = localizer;
            StringLocalizer = stringLocalizer;
        }

        private readonly ILogger<HomeController> _logger;

        public IStringLocalizer<HomeController> Localizer { get; }
        public IStringLocalizer<SampleResources> StringLocalizer { get; }

        public ActionResult<string> Get()
        {
            string result = Localizer["Home"];

            _logger.LogInformation(result);

            LocalizedString smth =
                Localizer.GetString(nameof(SampleResources.PageHeader));

            return result;
        }

        //public IActionResult Index() => View(Localizer["Home"]);


        //public IActionResult Privacy() => View();

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error() => 
        //    View(model: new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
