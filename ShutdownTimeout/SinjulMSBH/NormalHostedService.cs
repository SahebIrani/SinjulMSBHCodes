using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ShutdownTimeout.SinjulMSBH
{
    public class NormalHostedService : IHostedService
    {
        public NormalHostedService(ILogger<NormalHostedService> logger) 
            => Logger = logger ?? throw new ArgumentNullException(nameof(logger));

        public ILogger<NormalHostedService> Logger { get; }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Logger.LogInformation("NormalHostedService started .. !!!!");

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Logger.LogInformation("NormalHostedService stopped .. !!!!");

            return Task.CompletedTask;
        }
    }
}
