using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ShutdownTimeout.SinjulMSBH
{
    public class SlowHostedService : IHostedService
    {
        public SlowHostedService(ILogger<NormalHostedService> logger)
            => Logger = logger ?? throw new ArgumentNullException(nameof(logger));

        public ILogger<NormalHostedService> Logger { get; }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Logger.LogInformation("SlowHostedService started .. !!!!");

            return Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Logger.LogInformation("SlowHostedService stopping .. !!!!");

            await Task.Delay(8_000);

            Logger.LogInformation("SlowHostedService stopped .. !!!!");
        }
    }
}
