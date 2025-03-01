using ConsoleApp.Interfaces;

namespace ConsoleApp.Classes
{
    public class Reporting : IReporting
    {
        private List<Warehouse> stock = new List<Warehouse>();

        public void RegisterSupply(Warehouse item)
        {
            stock.Add(item);
            Console.WriteLine($"Added {item.Quantity} {item.Unit} of {item.Name}.");
        }

        public void RegisterShipment(string name, int quantity)
        {
            var item = stock.Find(p => p.Name == name);
            if (item != null && item.Quantity >= quantity)
            {
                item.Quantity -= quantity;
                Console.WriteLine($"Shipped {quantity} {item.Unit} of {item.Name}.");
            }
            else
            {
                Console.WriteLine("Insufficient stock.");
            }
        }

        public void InventoryReport()
        {
            Console.WriteLine("Inventory Report:");
            foreach (var item in stock)
            {
                Console.WriteLine($"{item.Name}: {item.Quantity} {item.Unit}, Last Supply: {item.LastSupplyDate}");
            }
        }
    }
}
