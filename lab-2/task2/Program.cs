using System.Text;
using task2.Devices;
using task2.Factories;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        IDeviceFactory iproneFactory = new IProneFactory();
        IDeviceFactory kiaomiFactory = new KiaomiFactory();
        IDeviceFactory balaxyFactory = new BalaxyFactory();

        IDevice iproneLaptop = iproneFactory.CreateLaptop();
        IDevice kiaomiSmartphone = kiaomiFactory.CreateSmartphone();
        IDevice balaxyEBook = balaxyFactory.CreateEBook();

        iproneLaptop.ShowDetails();
        kiaomiSmartphone.ShowDetails();
        balaxyEBook.ShowDetails();
    }
}