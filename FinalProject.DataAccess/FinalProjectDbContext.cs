using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FinalProject.DB.Entities; 

namespace FinalProject.DataAccess
{
    public class FinalProjectDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Manafacturer> Manafacturer { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

    }
}
