using CorrelationId.Abstractions;
using Microsoft.AspNetCore.Http;

namespace CorrelationIdentifier.SinjulMSBH
{
    public class DoNothingCorrelationIdProvider : ICorrelationIdProvider
    {
        public string GenerateCorrelationId(HttpContext context) => context?.TraceIdentifier;
    }
}