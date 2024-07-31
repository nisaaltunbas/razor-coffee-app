namespace RazorCoffeApp.Models
{
    public class CoffeesModel
    {
        public string ImageTitle { get; set; }
        public string CoffeeName { get; set; }
        public float BasePrice { get; set; } = 3;
        public string? BeanType { get; set; }
        public string? MilkType { get; set; }
        public bool Milk { get; set; }
        public bool Vanilla { get; set; }
        public string? SyrupType { get; set; }
        public string? SweetenersType { get; set; }
        public bool ExtraShot { get; set; }
        public string? CreamType { get; set; }
        public bool Cinnamon { get; set; }
        public bool Cardamom { get; set; }
        public bool ChocolateChips { get; set; }
        public bool CaramelSauces { get; set; }
        public float FinalPrice { get; set; }
    }
}
