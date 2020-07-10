using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CorrelationIdentifier.SinjulMSBH
{
    public abstract class ApiClient
    {
        private readonly HttpClient httpClient;
        private readonly CorrelationIDs correlationIDs;

        protected ApiClient(HttpClient httpClient, CorrelationIDs correlationIDs)
        {
            this.httpClient = httpClient;
            this.correlationIDs = correlationIDs;
        }

        public async Task<HttpResponseMessage> SendAsync(HttpMethod method, string uri)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(httpClient.BaseAddress + uri),
                Method = method
            };

            AddCorrelationHeaders(request, correlationIDs);

            return await httpClient.SendAsync(request);
        }

        private void AddCorrelationHeaders(HttpRequestMessage request, CorrelationIDs correlationIDs)
        {
            foreach (var (key, value) in correlationIDs.GetCurrentIDs())
            {
                request.Headers.Add(key, value.ToString());
            }
        }
    }
}
