using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCoffeApp.Models;

namespace RazorCoffeApp.Pages.Forms
{
    public class CustomCoffeeModel : PageModel
    {
        [BindProperty]
        public CoffeesModel Coffee { get; set; }
        public float CoffeePrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            CoffeePrice = Coffee.BasePrice;

            // Beans
            switch (Coffee.BeanType)
            {
                case "Arabica":
                    CoffeePrice += 1;
                    break;
                case "Robusta":
                    CoffeePrice += 1;
                    break;
                case "Liberica":
                    CoffeePrice += 1;
                    break;
                case "Excelsa":
                    CoffeePrice += 1;
                    break;
            }

            // Milk
            switch (Coffee.MilkType)
            {
                case "WholeMilk":
                    CoffeePrice += 0;
                    break;
                case "SemiSkimmedMilk":
                    CoffeePrice += 1;
                    break;
                case "SkimmedMilk":
                    CoffeePrice += 2;
                    break;
                case "AlmondMilk":
                    CoffeePrice += 2;
                    break;
                case "OatMilk":
                    CoffeePrice += 3;
                    break;
                case "SoyMilk":
                    CoffeePrice += 3;
                    break;
            }
            // Syrups
            switch (Coffee.SyrupType)
            {
                case "Vanilla":
                    CoffeePrice += 1;
                    break;
                case "Caramel":
                    CoffeePrice += 1;
                    break;
            }
            // Sweeteners
            switch (Coffee.SweetenersType)
            {
                case "Sugar":
                    CoffeePrice += 0;
                    break;
                case "BrownSugar":
                    CoffeePrice += 1;
                    break;
            }
            // Cream
            switch (Coffee.CreamType)
            {
                case "WhippedCream":
                    CoffeePrice += 0;
                    break;
                case "MoreFoam":
                    CoffeePrice += 1;
                    break;
                case "NoFoam":
                    CoffeePrice += 0;
                    break;
            }
            // Extra shot
            if (Coffee.ExtraShot) CoffeePrice += 1;
            // Spices and Extras
            if (Coffee.Cinnamon) CoffeePrice += 1;
            if (Coffee.Cardamom) CoffeePrice += 1;
            if (Coffee.ChocolateChips) CoffeePrice += 2;
            if (Coffee.CaramelSauces) CoffeePrice += 1;


            return RedirectToPage("/Checkout/Checkout", new { Coffee.CoffeeName, CoffeePrice });
        }
    }
}
