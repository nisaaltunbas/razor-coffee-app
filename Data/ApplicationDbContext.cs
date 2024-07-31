using Microsoft.EntityFrameworkCore;
using RazorCoffeeApp.Models;


namespace RazorCoffeeApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<CoffeeOrder> CoffeeOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
    }
}
