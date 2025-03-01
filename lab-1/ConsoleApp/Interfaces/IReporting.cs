using ConsoleApp.Classes;

namespace ConsoleApp.Interfaces
{
    interface IReporting
    {
        void RegisterSupply(Warehouse item);
        void RegisterShipment(string name, int quantity);
        void InventoryReport();
    }
}
