using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Devices;

namespace task2.Factories
{
    class BalaxyFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("Balaxy");
        public IDevice CreateNetbook() => new Netbook("Balaxy");
        public IDevice CreateEBook() => new EBook("Balaxy");
        public IDevice CreateSmartphone() => new Smartphone("Balaxy");
    }
}
