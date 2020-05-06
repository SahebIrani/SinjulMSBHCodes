
using Microsoft.Extensions.Logging;

using ZLogger;

namespace ZLoggerDemo.SinjulMSBH
{
    public class MyClass
    {
        readonly ILogger<MyClass> logger;

        //? get logger from DI.
        public MyClass(ILogger<MyClass> logger) => this.logger = logger;

        public void Foo()
        {
            //? ZLog, ZLogTrace, ZLogDebug, ZLogInformation, ZLogWarning, ZLogError, ZLogCritical and *WithPayload.
            //! public static void ZLogDebug(this ILogger logger, string format);
            //! public static void ZLogDebug(this ILogger logger, EventId eventId, string format);
            //! public static void ZLogDebug(this ILogger logger, Exception? exception, string format);
            //! public static void ZLogDebug(this ILogger logger, EventId eventId, Exception? exception, string format);
            //! public static void ZLogDebug<T1>(this ILogger logger, string format, T1 arg1);
            //! public static void ZLogDebug<T1>(this ILogger logger, EventId eventId, string format, T1 arg1);
            //! public static void ZLogDebug<T1>(this ILogger logger, Exception? exception, string format, T1 arg1);
            //! public static void ZLogDebug<T1>(this ILogger logger, EventId eventId, Exception? exception, string format, T1 arg1);
            // T1~T16
            //? public static void ZLogDebug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            //? (this ILogger logger, EventId eventId, Exception? exception, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            //? T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);

            //? log text.
            logger.ZLogDebug("foo{0} bar{1}", 10, 20);

            //? log text with structure in Structured Logging.
            logger.ZLogDebugWithPayload(new { Foo = 10, Bar = 20 }, "foo{0} bar{1}", 10, 20);
        }
    }
}
