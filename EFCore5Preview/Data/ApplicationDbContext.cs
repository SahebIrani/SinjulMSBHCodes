using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EFCore5Preview.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder =
                new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder
                .UseSqlServer("Server=SINJULMSBH\\MSSQLSERVERS2019;Database=EFCorePreviewDB;Trusted_Connection=True;MultipleActiveResultSets=true")
            ;

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }

    //public class MyDbContextFactory : IDesignTimeDbContextFactory<SomeDbContext>
    //{
    //    //? Flow arguments into IDesignTimeDbContextFactory
    //    //! dotnet ef migrations add two --verbose --dev

    //    public SomeDbContext CreateDbContext(string[] args)
    //        => new SomeDbContext(args.Contains("--dev"));
    //}
    //public class SomeDbContext : DbContext
    //{
    //    private readonly bool v;

    //    public SomeDbContext(bool v) => this.v = v;
    //}

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Host> Hosts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            #region Simple Logging
            //optionsBuilder.LogTo(Console.WriteLine);
            //? Set the minimum log level
            //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            //? Filter for only specific events:
            //? optionsBuilder.LogTo(Console.WriteLine, new[] { CoreEventId.ContextInitialized, RelationalEventId.CommandExecuted });
            //? Filter for all events in specific categories:
            //? optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Name }, LogLevel.Information);
            //? Use a custom filter over event and level:
            optionsBuilder
                .LogTo(Console.WriteLine, (id, level) => id == RelationalEventId.CommandExecuting)
                .EnableDetailedErrors(detailedErrorsEnabled: true)
                .EnableSensitiveDataLogging(sensitiveDataLoggingEnabled: true) //? Often also useful with EnableDetailedErrors 
            ;
            #endregion
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //? A new IsRelational method has been added in addition to the existing IsSqlServer, IsSqlite, and IsInMemory. 
            //? if (Database.IsRelational())
            //{
            //	modelBuilder.Entity<Address>().HasNoKey();
            //}
            //else Console.WriteLine("Database != IsRelational");

            modelBuilder.Entity<Address>().HasNoKey();


            //? New ModelBuilder API for navigation properties
            // modelBuilder.Entity<Shop>().Navigation(_ => _.Customers).HasField("_mainTitle");

            //? Configure database precision / scale in model
            modelBuilder
                .Entity<Shop>()
                .Property(b => b.Numeric)
                //! Precision and scale can still be set via the full database type, 
                //! such as “decimal(17,4)”.
                .HasPrecision(17, 4)
            ;

            //? Specify SQL Server index fill factor
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);
                entity
                    .HasIndex(e => e.FullName)
                    .HasName("IX_FullName")
                    .HasFillFactor(90)
                ;
            });


            //? What's new in EF Core 5 Preview 5
            //! Database collations

            //modelBuilder.UseCollation("Persian_PhoneBook");

            //modelBuilder
            //.Entity<Customer>()
            //.Property(e => e.FullName)
            //.UseCollation("Persian_PhoneBook");

            //? Stored(persisted) computed columns
            //modelBuilder
            //    .Entity<Customer>()
            //    .Property(e => e.SomethingComputed)
            //    .HasComputedColumnSql("my sql", stored: true);

            //? SQLite computed columns
            //! EF Core now supports computed columns in SQLite databases.
        }
    }


    [Keyless]
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public DateTime CreateDate { get; set; }
    }
    public class Customer
    {
        //? Use a C# attribute to specify a property backing field
        private string _mainTitle;

        [BackingField(nameof(_mainTitle))]
        public string Title
        {
            get => _mainTitle;
            set => _mainTitle = value;
        }


        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public byte[] Picture { get; set; }
        public DateTimeOffset OrderDate { get; set; }


        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
        //public string SomethingComputed { get; set; }
    }

    public class Shop
    {
        public int ShopId { get; set; }


        //? Use a C# attribute to specify a property backing field
        private string _mainTitle;

        [BackingField(nameof(_mainTitle))]
        public string Title
        {
            get => _mainTitle;
            set => _mainTitle = value;
        }

        public virtual ICollection<Customer> Customers { get; set; }
        public decimal Numeric { get; set; }
    }




    //? IndexAttribute
    [Index(nameof(FullName), IsUnique = true)]        
    //? Multiple Index
    [Index(nameof(FirstName), nameof(LastName), IsUnique = true)]
    public class Artist
    {
        public int ArtistId { get; set; }


        [MaxLength(128)]
        public string FullName { get; set; }


        [MaxLength(64)]
        public string FirstName { get; set; }

        [MaxLength(64)]
        public string LastName { get; set; }


        public bool IsSigned { get; set; }


        public virtual ICollection<Album> Albums { get; set; }
    }


    public class Album
    {
        public int AlbumId { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }

    public class Tag
    {
        public int TagId { get; set; }


        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
    }

    //? IPAddress mapping
    public class Host
    {
        public int Id { get; set; }
        public IPAddress Address { get; set; }
    }
}
