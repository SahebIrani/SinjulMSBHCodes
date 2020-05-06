using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ZLogger;

using ZLoggerDemo.Models;
using ZLoggerDemo.SinjulMSBH;

namespace ZLoggerDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // In default, output JSON with log information(categoryName, level, timestamp, exception), message and payload(if exists).

            // {"CategoryName":"ConsoleApp.Program","LogLevel":"Information","EventId":0,"EventIdName":null,"Timestamp":"2020-04-07T11:53:22.3867872+00:00","Exception":null,"Message":"Registered User: Id = 10, UserName = Mike","Payload":null}
            _logger.ZLogInformation("Registered User: Id = {0}, UserName = {1}", 13, "SinjulMSBH");

            // {"CategoryName":"ConsoleApp.Program","LogLevel":"Information","EventId":0,"EventIdName":null,"Timestamp":"2020-04-07T11:53:22.3867872+00:00","Exception":null,"Message":"Registered User: Id = 10, UserName = Mike","Payload":{"Id":10,"Name":"Mike"}}
            _logger.ZLogInformationWithPayload(new UserRegisteredLog { Id = 13, Name = "SinjulMSBH" },
                "Registered User: Id = {0}, UserName = {1}", 13, "SinjulMSBH");

            return View();
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
