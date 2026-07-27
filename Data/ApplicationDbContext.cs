using Microsoft.EntityFrameworkCore;
using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
    }
}
