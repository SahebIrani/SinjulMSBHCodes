﻿
using Microsoft.Extensions.Logging;

namespace ZLoggerDemo.SinjulMSBH
{
    //? Global LoggerFactory
    //? Own static loggger manager
    public static class LogManager
    {
        static ILogger globalLogger;
        static ILoggerFactory loggerFactory;

        public static void SetLoggerFactory(ILoggerFactory loggerFactory, string categoryName)
        {
            LogManager.loggerFactory = loggerFactory;
            LogManager.globalLogger = loggerFactory.CreateLogger(categoryName);
        }

        public static ILogger Logger => globalLogger;

        public static ILogger<T> GetLogger<T>() where T : class => loggerFactory.CreateLogger<T>();
        public static ILogger GetLogger(string categoryName) => loggerFactory.CreateLogger(categoryName);
    }
}
