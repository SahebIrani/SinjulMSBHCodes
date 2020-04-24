
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

using SinjulMSBH.Localization.Resources;
using SinjulMSBH.Localization.ViewModels;

namespace SinjulMSBH.Localization.Controllers
{
    [ApiController, Route("{culture:culture}/[controller]")]
    public class AboutController : ControllerBase
    {
        // Alert: Go to Bootstrapper.cs file and change AddLocalization() method ..
        public AboutController(IStringLocalizer<Resource> localizer) => Localizer = localizer;
        public IStringLocalizer<Resource> Localizer { get; }

        public string Get() => Localizer["About"];


        [HttpPost(nameof(LocalizaionPost))]
        public string LocalizaionPost([FromBody] ViewModel model)
        {
            return default;
        }

    }
}