using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCoffeApp.Models;

namespace RazorCoffeApp.Pages
{
    public class CoffeeModel : PageModel
    {

        public List<CoffeesModel> fakeCoffeeDB = new List<CoffeesModel>() {
            new CoffeesModel(){ImageTitle="americano",CoffeeName="Americano",BasePrice=3,ExtraShot=true,FinalPrice=4},
            new CoffeesModel(){ImageTitle="capuccino",CoffeeName="Cappucino",BasePrice=3,ExtraShot=true,Milk=true, FinalPrice=5},
            new CoffeesModel(){ImageTitle="espresso",CoffeeName="Espresso",BasePrice=3,ExtraShot=true,FinalPrice=4},
            new CoffeesModel(){ImageTitle="flatwhite",CoffeeName="Flat White",BasePrice=3,ExtraShot=true,Milk=true,FinalPrice=4},
            new CoffeesModel(){ImageTitle="latte",CoffeeName="Latte",BasePrice=3,ExtraShot=true,Milk=true,FinalPrice=4},
            new CoffeesModel(){ImageTitle="macchiato",CoffeeName="Macchiato",BasePrice=3,ExtraShot=true,Milk = true,Vanilla=true,CaramelSauces=true,  FinalPrice=8},
            new CoffeesModel(){ImageTitle="mocha",CoffeeName="Mocha",BasePrice=3,ExtraShot=true,Milk=true,ChocolateChips=true,Vanilla=true, FinalPrice=7}


        };
        public void OnGet()
        {
        }
    }
}
