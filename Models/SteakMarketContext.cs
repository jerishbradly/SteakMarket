using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SteakMarket.Models
{
    public class SteakMarketContext : DbContext
    {
        public SteakMarketContext(DbContextOptions<SteakMarketContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
