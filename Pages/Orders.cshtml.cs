using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCoffeeApp.Data;
using RazorCoffeeApp.Models;

namespace RazorCoffeeApp.Pages
{
    public class OrdersModel : PageModel
    {
        public List<CoffeeOrder> CoffeeOrders = new List<CoffeeOrder>();
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            CoffeeOrders = _context.CoffeeOrders.ToList();
        }
    }
}
