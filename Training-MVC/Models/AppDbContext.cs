using Microsoft.EntityFrameworkCore;

namespace Task_Web_Product.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Items> items {get;set;}
        public DbSet<Purchase> purchases {get;set;}
        public DbSet<Page> page {get;set;}
        public DbSet<Carts> carts {get;set;}
        public DbSet<AccountModel> account {get;set;}
        public AppDbContext (DbContextOptions options):base(options)
        {
            
        }
    }
}