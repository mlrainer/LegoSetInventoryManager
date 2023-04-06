using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using LegoSetInventoryManager.Models;

namespace LegoSetInventoryManager.Demo.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
            DBInitializer.Initialize(this);
        }

        public DbSet<SetName> SetNames { get; set; }
        public DbSet<SetDetail> SetDetails { get; set; }
    }
}