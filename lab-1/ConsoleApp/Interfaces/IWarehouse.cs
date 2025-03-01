namespace ConsoleApp.Interfaces
{
    public interface IWarehouse
    {
        void UpdateStock(int quantity, DateTime lastSupplyDate);
    }
}
