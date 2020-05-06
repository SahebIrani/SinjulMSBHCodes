
using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

using Cysharp.Text;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using ZLogger; //? namespace

using ZLoggerDemo.SinjulMSBH;

namespace ZLoggerDemo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args).Build().RunAsync();

            //? Global LoggerFactory
            var host = Host.CreateDefaultBuilder()
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddZLoggerConsole();
            })
            //? .UseConsoleAppFramework<Program>(args) // use framework, example of ConsoleAppFramework
            .ConfigureWebHostDefaults(x => x.UseStartup<Startup>()) // example of ASP.NET Core
            .Build(); //! use Build instead of Run directly

            //? get configured loggerfactory.
            var loggerFactory = host.Services.GetRequiredService<ILoggerFactory>();

            LogManager.SetLoggerFactory(loggerFactory, "Global");

            //? Run after set global logger.
            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    //? If consoleOutputEncodingToUtf8 = true(default is true),
                    //? set Console.OutputEncoding = new UTF8Encoding(false) when the provider is created.
                    Console.OutputEncoding = new UTF8Encoding(true);

                    //? optional(MS.E.Logging):clear default providers.
                    logging.ClearProviders();

                    //? optional(MS.E.Logging): default is Info, 
                    //? you can use this or AddFilter to filtering log.
                    logging.SetMinimumLevel(LogLevel.Debug);

                    //? Add Console Logging.
                    logging.AddZLoggerConsole();

                    //? Add File Logging.
                    logging.AddZLoggerFile("fileName.log");

                    //? Add Rolling File Logging.
                    logging.AddZLoggerRollingFile((dt, x) =>
                        $"logs/{dt.ToLocalTime():yyyy-MM-dd}_" +
                        $"{x:000}.log", x => x.ToLocalTime().Date, 1024);

                    //? Enable Structured Logging
                    //? To setup, `EnableStructuredLogging = true`.
                    //? ZLogger natively supports StructuredLogging and uses System.Text.Json.JsonSerializer
                    logging.AddZLoggerConsole(options =>
                    {
                        options.EnableStructuredLogging = true;
                    });


                    //? Output to the Stream. This is useful when writing data to a MemoryStream or a NetworkStream.

                    var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                    //! socket.Connect("127.0.0.1", 12345);
                    var network = new NetworkStream(socket);
                    logging.AddZLoggerStream(network);


                    //? ZLogger allows to add multiple same type providers. In this case, you need to give it a different name in string optionName.

                    logging.AddZLoggerFile("plain-text.log", "file-plain", x =>
                    {
                        x.PrefixFormatter = (writer, info) =>
                            ZString.Utf8Format(writer, "[{0}]", info.Timestamp.ToLocalTime().DateTime);
                    });
                    logging.AddZLoggerFile("json.log", "file-structured", x => { x.EnableStructuredLogging = true; });

                    //? For performance reason, we do not use string so use the IBufferWriter<byte> instead.You can use ZString.Utf8Format to help set formatter.
                    logging.AddZLoggerConsole(options =>
                    {
                        options.PrefixFormatter = (writer, info) =>
                            ZString.Utf8Format(writer, "[{0}][{1}]", info.LogLevel, info.Timestamp.DateTime.ToLocalTime());

                        // Tips: use PrepareUtf8 to achive better performance.
                        var prefixFormat = ZString.PrepareUtf8<LogLevel, DateTime>("[{0}][{1}]");
                        options.PrefixFormatter = (writer, info) =>
                            prefixFormat.FormatTo(ref writer, info.LogLevel, info.Timestamp.DateTime.ToLocalTime());
                    });

                    //? output:
                    //? [Information][04/07/2020 20:21:46]fooooo!
                    //! logger.ZLogInformation("fooooo!");


                    //? If you want to add additional information to the JSON, modify the StructuredLoggingFormatter as follows, for example

                    logging.AddZLoggerConsole(options =>
                    {
                        options.EnableStructuredLogging = true;

                        var gitHashName = JsonEncodedText.Encode("GitHash");
                        var gitHashValue = JsonEncodedText.Encode("gitHash");

                        options.StructuredLoggingFormatter = (writer, info) =>
                        {
                            writer.WriteString(gitHashName, gitHashValue);
                            info.WriteToJsonWriter(writer);
                        };
                    });

                    //? {"GitHash":"XXXX","CategoryName":...,"Message":"...","Payload":...}
                    //! logger.ZLog(....

                    //? You can change the serialization behavior of the payload by changing the JsonSerializerOptions. If you want to set up a custom Converter, set it here. By default, the following configuration is used
                    var js = new JsonSerializerOptions
                    {
                        WriteIndented = false,
                        IgnoreNullValues = false,
                        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
                    };

                    //? Microsoft.CodeAnalysis.BannedApiAnalyzers

                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
