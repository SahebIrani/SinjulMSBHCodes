using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

using EFCore5Preview.Data;
using EFCore5Preview.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
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
                //ReferenceHandling = ReferenceHandling.Preserve

                ReferenceHandler = ReferenceHandler.Preserve //? after preview 6
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


        #region  Preview5


        [HttpGet(nameof(EFCore5Preview5))]
        public async ValueTask<OkObjectResult> EFCore5Preview5(CancellationToken ct = default)
        {
            //? What's new in EF Core 5 Preview 5
            //! Database collations
            //Customer customer = await
            //    ApplicationDbContext.Customers
            //        .SingleAsync(e => EF.Functions.Collate
            //                        (e.FullName, "Persian_PhoneBook") == "SinjulMSBH", ct)
            //;

            //? No-tracking queries with identity resolution
            IReadOnlyCollection<Customer> customersWithShop =
                await ApplicationDbContext.Customers
                    .AsNoTracking()
                    .Include(e => e.Shop)
                    .ToListAsync(ct)
            ;
            IReadOnlyCollection<Customer> customersWithShopNew =
                await ApplicationDbContext.Customers
                    .AsNoTracking()
                    //.PerformIdentityResolution()
                    .Include(e => e.Shop)
                    .ToListAsync(ct)
            ;


            return Ok(new { customersWithShop, customersWithShopNew });
        }


        #endregion


        #region  Preview6

        [HttpGet(nameof(EFCore5Preview6))]
        public async ValueTask<OkObjectResult> EFCore5Preview6(CancellationToken ct = default)
        {
            //? Split queries with Include

            IReadOnlyCollection<Artist> artists = await ApplicationDbContext.Artists
                .AsSplitQuery()
                .Include(e => e.Albums).ThenInclude(e => e.Tags)
                .OrderBy(c => c.ArtistId)
                .Skip(0)
                .Take(4)
                .ToListAsync(ct)
            ;

            //? Split queries with collection projections

            var artists2 = await ApplicationDbContext.Artists
                .AsSplitQuery()
                .Select(e => new
                {
                    Artist = e,
                    Albums = e.Albums,
                })
                .ToListAsync(ct)
            ;

            //? Improved query translation exceptions
            IReadOnlyCollection<Artist> artists3 = await ApplicationDbContext.Artists
                .Where(e => e.IsSigned)
                //.Where(e => e.FirstName.Equals("Jack Slater", StringComparison.CurrentCulture))
                .ToListAsync(ct)
            ;

            //? Specify transaction ID
            //using (IDbContextTransaction transaction =
            //    await ApplicationDbContext.Database.BeginTransactionAsync(ct))
            //{
            //    using (await ApplicationDbContext.Database
            //        .UseTransactionAsync(transaction.GetDbTransaction(), transaction.TransactionId, ct))
            //    {
            //    }
            //}

            //? IPAddress mapping
            await ApplicationDbContext.AddRangeAsync(
                new Host { Address = IPAddress.Parse("127.0.0.1") },
                new Host { Address = IPAddress.Parse("0000:0000:0000:0000:0000:0000:0000:0001") }
            );
            //await ApplicationDbContext.SaveChanges(ct);
            IReadOnlyCollection<Host> hosts = await ApplicationDbContext.Hosts.ToListAsync(ct);

            //? Exclude OnConfiguring when scaffolding
            //! dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB;
            //! Initial Catalog=Chinook" Microsoft.EntityFrameworkCore.SqlServer 
            //? --no - onconfiguring

            //? Or in the Package Manager Console:
            //! Scaffold - DbContext 'Data Source=(localdb)\MSSQLLocalDB;
            //! Initial Catalog=Chinook' Microsoft.EntityFrameworkCore.SqlServer 
            //? - NoOnConfiguring

            //? Translations for FirstOrDefault on strings
            //? Simplify case blocks
            IReadOnlyCollection<Customer> customers =
                await ApplicationDbContext.Customers
                .Where(c => c.FullName.FirstOrDefault() == 'J')
                .OrderBy(w => w.FullName.CompareTo("Jack Slater") == 0)
                .ThenBy(w => w.CustomerId)
                .ToListAsync(ct)
            ;

            return Ok(new { artists, artists2, artists3,/* hosts,*/ customers });
        }

        #endregion


        #region  Preview7

        [HttpGet(nameof(EFCore5Preview7))]
        public async ValueTask<OkObjectResult> EFCore5Preview7(
            [FromServices] IDbContextFactory<SomeDbContext> dbContextFactory,
            CancellationToken ct = default)
        {
            //? DbContextFactory
            using SomeDbContext context = dbContextFactory.CreateDbContext();

            //? Reset DbContext state
            context.ChangeTracker.Clear();
            await context.GetDependencies().StateManager.ResetStateAsync();

            //? New pattern for store-generated defaults
            //! and .HasDefaultValue(true);

            //? Save Points
            //? EF Core now supports savepoints for greater control over transactions that execute multiple operations.
            //? Savepoints can be manually created, released, and rolled back. For example:
            await context.Database.CreateSavepointAsync(name: "SinjulMSBHSavePoint", cancellationToken: ct);
            //? In addition, EF Core will now roll back to the last savepoint when executing SaveChanges fails.
            //? This allows SaveChanges to be re-tried without re-trying the entire transaction.
            // https://docs.microsoft.com/en-us/ef/core/saving/transactions
            // https://en.wikipedia.org/wiki/Savepoint

            return default;
        }

        #endregion








        public string Index()
        {
            string traceId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;


            var traceId1 = Activity.Current;
            var traceId2 = Activity.DefaultIdFormat;
            var traceId3 = Activity.ForceDefaultIdFormat;


            return traceId;
        }



        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
