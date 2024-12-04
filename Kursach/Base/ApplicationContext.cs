using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kursach
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<Inventory_price> Inventory { get; set; } = null!;
        public DbSet<Transport> Transport { get; set; } = null!;
        public DbSet<Office_equipment> Office_Equipment { get; set; } = null!;
        public DbSet<Realestate> Realestates { get; set; } = null!;

        public ApplicationContext() 
        { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\macar\\source\\repos\\Kursach\\Kursach\\Fishing.db");
        }
    }
}
