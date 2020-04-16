
using System.Collections.Generic;

using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ChooseFreePort.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(ILogger<IndexModel> logger) => _logger = logger;
        private readonly ILogger<IndexModel> _logger;

        public ICollection<string> Addresses { get; set; }

        public void OnGet([FromServices] IServer server)
        {
            // IApplicationBuilder exposes an IFeatureCollection property, ServerFeatures
            IServerAddressesFeature addressFeature = server.Features.Get<IServerAddressesFeature>();

            ICollection<string> addresses = addressFeature.Addresses;

            Addresses = addresses;

            foreach (string address in addresses)
                _logger.LogInformation("Listing on address: " + address);
        }
    }
}
