using ConsoleApp.Classes;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Money money = new Money(10, 50);
        Console.WriteLine(money);
        money.SetValue(20, 75);
        Console.WriteLine(money);

        Product product = new Product("Laptop", new Money(999, 99));
        Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
        product.DecreasePrice(100, 50);
        Console.WriteLine($"New Price: {product.Price}");

        Warehouse warehouse = new Warehouse("Laptop", "pcs", new Money(900, 00), 10, DateTime.Now);
        Console.WriteLine($"Warehouse: {warehouse.Name}, Stock: {warehouse.Quantity} {warehouse.Unit}");
        warehouse.UpdateStock(5, DateTime.Now);
        Console.WriteLine($"Updated Stock: {warehouse.Quantity} {warehouse.Unit}");

        Reporting reporting = new Reporting();
        reporting.RegisterSupply(warehouse);
        reporting.RegisterShipment("Laptop", 3);
        reporting.InventoryReport();
    }
}
