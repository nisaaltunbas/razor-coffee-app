using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RazorCoffeApp.Models;
using RazorCoffeeApp.Data;
using RazorCoffeeApp.Models;

namespace RazorCoffeApp.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string CoffeeName { get; set; }
        public float CoffeePrice  { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(CoffeeName))
            {
                CoffeeName = "Coffee";
            }
            if(string.IsNullOrWhiteSpace(ImageTitle)) {
                ImageTitle = "default";
            }
            CoffeeOrder coffeeOrder = new CoffeeOrder();
            coffeeOrder.CoffeeName = CoffeeName;
            coffeeOrder.BasePrice = CoffeePrice;

            _context.CoffeeOrders.Add(coffeeOrder);
            _context.SaveChanges();
        }
    }
}
