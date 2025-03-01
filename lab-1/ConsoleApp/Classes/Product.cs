using ConsoleApp.Interfaces;

namespace ConsoleApp.Classes
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public Money Price { get; private set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void DecreasePrice(int whole, int cents)
        {
            int totalCents = Price.WholePart * 100 + Price.Cents - (whole * 100 + cents);
            if (totalCents < 0) totalCents = 0;
            Price.SetValue(totalCents / 100, totalCents % 100);
        }
    }
}
