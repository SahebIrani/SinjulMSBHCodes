using System;

using Microsoft.Extensions.Logging;

using ZLogger;

namespace ZLoggerDemo.SinjulMSBH
{
    public class UserModel
    {
        //? Preparing Message Format
        static readonly Action<ILogger, int, string, Exception?> registerdUser =
            ZLoggerMessage.Define<int, string>(LogLevel.Information,
                new EventId(9, "RegisteredUser"), "Registered User: Id = {0}, UserName = {1}");

        readonly ILogger<UserModel> logger;

        public UserModel(ILogger<UserModel> logger) => this.logger = logger;

        public void RegisterUser(int id, string name)
        {
            //? ...do anything

            //? use defined delegate instead of ZLog.
            registerdUser(logger, id, name, null);
        }
    }

    public class UserModel2
    {
        //? Preparing Message Format
        static readonly Action<ILogger, UserRegisteredLog, int, string, Exception?> registerdUser =
            ZLoggerMessage.Define<UserRegisteredLog, int, string>(LogLevel.Information, 
                new EventId(9, "RegisteredUser"), "Registered User: Id = {0}, UserName = {1}");

        readonly ILogger<UserModel> logger;

        public UserModel2(ILogger<UserModel> logger) => this.logger = logger;

        public void RegisterUser(int id, string name)
        {
            //? ...do anything

            //? use defined delegate instead of ZLog.
            registerdUser(logger, new UserRegisteredLog { Id = id, Name = name }, id, name, null);
        }
    }
}
