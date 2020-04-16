using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace ChooseFreePort.SinjulMSBH
{
    public class ServerAddressesMiddleware
    {
        public ServerAddressesMiddleware(RequestDelegate _, IServer server) => _features = server.Features;
        private readonly IFeatureCollection _features;

        public async Task Invoke(HttpContext context)
        {
            // fetch the addresses
            IServerAddressesFeature addressFeature = _features.Get<IServerAddressesFeature>();
            ICollection<string> addresses = addressFeature.Addresses;

            // Write the addresses as a comma separated list
            await context.Response.WriteAsync(string.Join(",", addresses));
        }
    }
}
