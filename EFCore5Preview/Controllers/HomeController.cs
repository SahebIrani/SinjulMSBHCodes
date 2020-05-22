using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

using EFCore5Preview.Data;
using EFCore5Preview.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace EFCore5Preview.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(
            ILogger<HomeController> logger,
            ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            ApplicationDbContext = applicationDbContext;
        }

        private readonly ILogger<HomeController> _logger;
        public ApplicationDbContext ApplicationDbContext { get; }


        #region Preview1
        [HttpGet(nameof(EFCore5CreateDbCommandQueryStringAsync))]
        public async ValueTask<OkResult> EFCore5CreateDbCommandQueryStringAsync(CancellationToken ct = default)
        {
            //? Simple way to get generated SQL
            const string city = "Sari";
            IQueryable<Address> query = ApplicationDbContext.Addresses.Where(c => c.City == city);
            string queryString = query.ToQueryString();

            Console.WriteLine(queryString);
            _logger.LogInformation(queryString);

            //? This will work in simple cases, but the translation to a query string and back to a command loses some information. For example,
            //? if a transaction is being used then the code above would need to find that transaction and associate itself.
            DbConnection connection = ApplicationDbContext.Database.GetDbConnection();
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = query.ToQueryString();

                await connection.OpenAsync(ct);

                using (DbDataReader results = await command.ExecuteReaderAsync(ct))
                {
                }

                await connection.CloseAsync();
            }

            //? Instead, EF Core 5.0 introduces CreateDbCommand which creates and configures a DbCommand just as EF does to execute the query. For example:
            DbConnection connection2 = ApplicationDbContext.Database.GetDbConnection();
            using (DbCommand command = query.CreateDbCommand())
            {
                await connection2.OpenAsync(ct);

                using (DbDataReader results = command.ExecuteReader())
                {
                }

                await connection2.CloseAsync();
            }

            return Ok();
        }


        [HttpGet(nameof(EFCore5DemoAsync))]
        public async ValueTask<OkResult> EFCore5DemoAsync(CancellationToken ct = default)
        {
            //? Simple way to get generated SQL
            IQueryable<Address> query = ApplicationDbContext.Addresses.Where(c => c.City == "Sari");
            string queryString = query.ToQueryString();

            Console.WriteLine(queryString);
            _logger.LogInformation(queryString);

            //? Query translations for more DateTime constructs
            int count = await ApplicationDbContext.Addresses
                .CountAsync(c => c.CreateDate >= EF.Functions.DateFromParts(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), ct);

            //? Query translations for more byte array constructs
            IEnumerable<Customer> blogs =
                await ApplicationDbContext.Customers.Where(e => e.Picture.Contains((byte)127)).ToListAsync(ct);

            //? Query translation for Reverse
            IEnumerable<Customer> getReverse =
                await ApplicationDbContext.Customers.OrderBy(e => e.CustomerId).Reverse().ToListAsync(ct);

            //? Query translation for bitwise operators
            //? &(bitwise AND)
            //? | (bitwise OR)
            //? ~(bitwise NOT)
            //? ^(bitwise XOR)
            //? << (bitwise left shift)
            //? >> (bitwise right shift)
            //? >>> (bitwise unsigned right shift)
            //? &= (bitwise AND assignment)
            //? |= (bitwise OR assignment)
            //? ^= (bitwise XOR assignment)
            //? <<= (bitwise left shift and assignment)
            //? >>= (bitwise right shift and assignment)
            //? >>>= (bitwise unsigned right shift and assignment)
            IEnumerable<Customer> getNegated =
                await ApplicationDbContext.Customers.Where(o => ~o.CustomerId == -2).ToListAsync(ct);

            return Ok();
        }
        #endregion


        #region Preview2

        [HttpGet(nameof(EFCore5Preview2))]
        public async ValueTask<OkObjectResult> EFCore5Preview2(CancellationToken ct = default)
        {
            //? PropertyBackingField

            string[] listOfTiltle =
                await ApplicationDbContext.Customers.AsNoTracking().Select(_ => _.Title).ToArrayAsync(ct);

            string[] listOfShop =
                await ApplicationDbContext.Shop.AsNoTracking().Select(_ => _.Title).ToArrayAsync(ct);

            return Ok(new { listOfTiltle, listOfShop });
        }

        #endregion


        #region Preview3

        [HttpGet(nameof(EFCore5Preview3))]
        public async ValueTask<JsonResult> EFCore5Preview3(CancellationToken ct = default)
        {
            //? Filtered Include ..
            IReadOnlyCollection<Shop> shop =
                await ApplicationDbContext.Shop.AsNoTracking()
                     .Include(_ => _.Customers.Where(p => p.Title.Contains("BackingField")))
                     .ToListAsync(ct)
            ;

            //? Filtered Include with Skip and Take ..
            IReadOnlyCollection<Shop> shops =
                await ApplicationDbContext.Shop.AsNoTracking()
                    .Include(_ =>
                        _.Customers.OrderByDescending(post => post.Title)
                        .Skip(0)
                        .Take(4)
                    )
                    .ToListAsync(ct)
            ;

            //? Support for the SQL Server DATALENGTH function ..
            int count = await ApplicationDbContext.Customers.AsNoTracking()
                .CountAsync(_ => 44 < EF.Functions.DataLength(_.OrderDate), ct)
            ;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                ReferenceHandling = ReferenceHandling.Preserve
            };

            string res1 = JsonSerializer.Serialize(shop, options);
            string res2 = JsonSerializer.Serialize(shops, options);

            return Json(new { shop, shops, count }, options);
        }

        #endregion


        #region Preview4

        [HttpGet(nameof(EFCore5Preview4))]
        public async ValueTask<OkObjectResult> EFCore5Preview4(CancellationToken ct = default)
        {
            //? database precision/scale in model
            var q1 = await ApplicationDbContext.Shop.AsNoTracking()
                        .Where(_ => _.Numeric > 4 && _.Numeric < 17)
                        .ToListAsync(ct)
            ;


            //? Specify SQL Server index fill factor
            var q2 = await ApplicationDbContext.Customers.AsNoTracking()
                        .Where(_ => _.FullName.Contains("SinjulMSBH"))
                        .ToListAsync(ct)
            ;


            return Ok(new { q1, q2 });
        }

        #endregion



        public IActionResult Index() => View();

        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
