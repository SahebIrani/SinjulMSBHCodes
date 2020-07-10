using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace CorrelationIdentifier.SinjulMSBH
{
    public class LogContextMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<LogContextMiddleware> logger;

        public LogContextMiddleware(RequestDelegate next, ILogger<LogContextMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public Task InvokeAsync(HttpContext context)
        {
            //? header could be: Correlation-Context: userId=sergey,serverNode=DF,isProduction=false

            var correlationHeaders = Activity.Current.Baggage.ToDictionary(b => b.Key, b => (object)b.Value);

            // ensures all entries are tagged with some values   
            using (logger.BeginScope(correlationHeaders))
            {
                // Call the next delegate/middleware in the pipeline     
                return next(context);
            }
        }

        public Task InvokeAsync(HttpContext context, CorrelationIDs correlationIDs)
        {
            var correlationHeaders = context.Request.Headers
                .Where(h => h.Key.ToLowerInvariant().StartsWith("x-correlation-"))
                .ToDictionary(h => h.Key, h => (object)h.Value.ToString());

            foreach (var correlationHeader in correlationHeaders)
            {
                correlationIDs.Update(correlationHeader.Key, correlationHeader.Value.ToString());
            }

            // ensures all entries are tagged with some values
            using (logger.BeginScope(correlationIDs.GetCurrentIDs()))
            {
                // Call the next delegate/middleware in the pipeline
                return next(context);
            }
        }
    }
}
