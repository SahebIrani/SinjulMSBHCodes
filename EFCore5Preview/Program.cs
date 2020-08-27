
using System;
using System.Text.RegularExpressions;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace EFCore5Preview
{
    public class SinjulMSBHBase
    {
        public int Id { get; set; }
    }

    public class SinjulMSBH : SinjulMSBHBase
    {
    }

    public class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args).Build().RunAsync();

            {
                int max = Math.Max(4, 8);

                _ = typeof(Program).Name;
                _ = nameof(Program);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
