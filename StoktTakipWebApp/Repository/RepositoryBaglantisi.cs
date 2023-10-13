using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using StoktTakipWebApp.Models;

namespace StoktTakipWebApp.Repository
{
    public class RepositoryBaglantisi : DbContext
    {
        public RepositoryBaglantisi(DbContextOptions opt) : base (opt)
        { 

        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
          
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=Stok_Takip_uygulamasi; Trusted_Connection=True");
        }
        public DbSet<Product> Products { get; set; }
    }
}
