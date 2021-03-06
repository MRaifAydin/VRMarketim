using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess
{
    class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("host=localhost;database=VrMarketim;user id=postgres;password=123456;");

        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<GeneralProduct> GeneralProducts { get; set; }

        public DbSet<Basket> Baskets { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Card> Cards { get; set; }

    }
}
