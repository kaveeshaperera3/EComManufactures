using EComManufactures.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EComManufactures.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Computer> Computers { get; set; }        
        public DbSet<VirusGuard> virusGuards { get; set; }
        public DbSet<Ram> rams { get; set; }
        public DbSet<Processor> processors { get; set; }
        public DbSet<Hard> Hards { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
