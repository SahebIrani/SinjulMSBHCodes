using System;
using System.Collections.Generic;
using System.Linq;

namespace CorrelationIdentifier.SinjulMSBH
{
    public class CorrelationIDs
    {
        private readonly Dictionary<string, string> currentIDs = new Dictionary<string, string>();

        private const string CorrelationIdKey = "x-correlation-id";

        public CorrelationIDs() => currentIDs[CorrelationIdKey] = Guid.NewGuid().ToString();

        public IReadOnlyDictionary<string, object> GetCurrentIDs() =>
            currentIDs.ToDictionary(k => k.Key, k => (object)k.Value);

        public void Update(string key, string value) => currentIDs[key] = value;
    }
}
