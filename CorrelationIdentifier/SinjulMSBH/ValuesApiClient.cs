using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

namespace CorrelationIdentifier.SinjulMSBH
{
    public interface IValuesApiClient
    {
        Task<ValueItem> GetValueItem(string key);
    }

    public class ValueItem
    {
    }

    public class ValuesApiClient : ApiClient, IValuesApiClient
    {
        private readonly ILogger<ValuesApiClient> logger;
        public ValuesApiClient(HttpClient httpClient, CorrelationIDs correlationIDs, ILogger<ValuesApiClient> logger)
            : base(httpClient, correlationIDs) => this.logger = logger;
        public async Task<ValueItem> GetValueItem(string key)
        {
            logger.LogInformation("Calling Values Api. {Key}", key);
            var response = await SendAsync(HttpMethod.Get, $"api/values/{key}");
            var json = await response.Content.ReadAsStreamAsync();
            var result = await JsonSerializer.DeserializeAsync<ValueItem>(json);
            return result;
        }
    }
}
