
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

using SinjulMSBH.Localization.SinjulMSBH.Resources;

namespace SinjulMSBH.Localization.Controllers
{
    [ApiController, Route("{culture:culture}/[controller]")]
    public class AboutController : ControllerBase
    {
        // Alert: Go to Bootstrapper.cs file and change AddLocalization() method ..
        public AboutController(IStringLocalizer<Resource> localizer) => Localizer = localizer;
        public IStringLocalizer<Resource> Localizer { get; }

        public string Get() => Localizer["About"];
    }
}