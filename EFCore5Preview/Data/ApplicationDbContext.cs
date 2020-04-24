﻿using System;
using System.Collections.Generic;

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

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shop> Shop { get; set; }

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
            //# modelBuilder.Entity<Shop>().Navigation(_ => _.Customers).HasField("_mainTitle");
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
    }

    public class Shop
    {
        //? Use a C# attribute to specify a property backing field
        private string _mainTitle;

        [BackingField(nameof(_mainTitle))]
        public string Title
        {
            get => _mainTitle;
            set => _mainTitle = value;
        }

        public int ShopId { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
