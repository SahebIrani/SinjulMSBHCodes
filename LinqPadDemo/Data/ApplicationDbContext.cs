using System;
using System.Collections.Generic;

using GenFu;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LinqPadDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            long i = 1, j = 1;
            string sFullName = "SinjulMSBH", jFullName = "JackSlater";

            GenFu.GenFu.Configure<DomainModels.SinjulMSBH>()
                .Fill(c => c.Id, () => i++)
                .Fill(b => b.FullName, () => sFullName)
                .Fill(p => p.Age).WithRandom(new int[] { 4, 8, 13, 17, 22, 24, 26, 31, 33, 35, 40, 44 })
                .Fill(p => p.IsActive).WithRandom(new bool[] { true, true, false, false })
                .Fill(x => x.BirthDate, () => DateTimeOffset.UtcNow)
            ;

            GenFu.GenFu.Configure<DomainModels.JackSlater>()
                .Fill(c => c.Id, () => j++)
                .Fill(b => b.FullName, () => jFullName)
                .Fill(p => p.Age).WithRandom(new int[] { 4, 8, 13, 17, 22, 24, 26, 31, 33, 35, 40, 44 })
                .Fill(p => p.IsActive).WithRandom(new bool[] { true, true, false, false })
                .Fill(x => x.BirthDate, () => DateTimeOffset.UtcNow)
                .Fill(x => x.SinjulMSBHId).WithRandom(new long?[] { 4, 8, 13, 17, 22, 24, 26, 31, 33, 35, 40, 44 })
            ;

            IList<DomainModels.SinjulMSBH> SinjulMSBH =
                A.ListOf<DomainModels.SinjulMSBH>(itemCount: 440);

            IList<DomainModels.JackSlater> JackSlater =
                A.ListOf<DomainModels.JackSlater>(itemCount: 440);

            builder.Entity<DomainModels.SinjulMSBH>().HasData(SinjulMSBH);
            builder.Entity<DomainModels.JackSlater>().HasData(JackSlater);
        }
    }
}
