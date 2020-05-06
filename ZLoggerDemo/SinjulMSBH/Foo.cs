
using Microsoft.Extensions.Logging;

using ZLogger;

namespace ZLoggerDemo.SinjulMSBH
{
    public class Foo
    {
        public static readonly ILogger<Foo> logger = LogManager.GetLogger<Foo>();

        public void DoDo(int x) => logger.ZLogDebug("do do do: {0}", x);
    }
}
