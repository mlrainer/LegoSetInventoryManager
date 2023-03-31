using System;
using LegoSets;
using Microsoft.EntityFrameworkCore;

namespace LegoSetInventoryManager.Data
{
    public class DBContext : DbContext

    {

        public DbSet<SetName> SetName { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<SetName>().ToTable("Set Name");

        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433; Database=LegoSetDB;User=mlrainer; Password=Etid267498!");


        public DBContext()

        {

        }


        public static DBContext Create()

        {

            return new DBContext();

        }


    }
}
