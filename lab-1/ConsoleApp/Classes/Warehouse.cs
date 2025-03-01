using ConsoleApp.Interfaces;

namespace ConsoleApp.Classes
{
    public class Warehouse : IWarehouse
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public Money PricePerUnit { get; set; }
        public int Quantity { get; set; }
        public DateTime LastSupplyDate { get; set; }

        public Warehouse(string name, string unit, Money price, int quantity, DateTime lastSupplyDate)
        {
            Name = name;
            Unit = unit;
            PricePerUnit = price;
            Quantity = quantity;
            LastSupplyDate = lastSupplyDate;
        }

        public void UpdateStock(int quantity, DateTime lastSupplyDate)
        {
            Quantity += quantity;
            LastSupplyDate = lastSupplyDate;
        }
    }
}
