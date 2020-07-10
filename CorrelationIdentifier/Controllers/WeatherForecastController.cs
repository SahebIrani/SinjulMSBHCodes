
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CorrelationIdentifier.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var client = _httpClientFactory.CreateClient("MyClient"); //? this client will attach the correlation ID header

            await client.GetAsync("https://www.example.com");

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<WeatherForecast>> GetAll()
        {
            var jsonStream = await
                      _httpClient.GetStreamAsync("http://localhost:5001/weatherforecast");

            var weatherForecast = await
                  JsonSerializer.DeserializeAsync<IEnumerable<WeatherForecast>>(jsonStream);

            return weatherForecast;
        }

        [HttpGet(nameof(GetAll2))]
        public async Task<string> GetAll2()
        {
            var activity = new Activity("CallToBackend").Start();

            var activity2 = new Activity("CallToBackend")
                .AddBaggage("appVersion", "v1.0")
                .Start()
            ;

            try
            {
                var appVersion = Activity.Current.Baggage.FirstOrDefault(b => b.Key == "appVersion").Value;
                using (_logger.BeginScope($"appVersion={appVersion}"))
                {
                    _logger.LogInformation("this weather forecast is from random source");
                }


                string traceId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;

                return await _httpClient.GetStringAsync(
                                       "http://localhost:5000/weatherforecastproxy");
            }
            finally
            {
                activity.Stop();
            }
        }
    }
}
