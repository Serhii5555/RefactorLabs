using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Devices
{
    class Netbook : IDevice
    {
        private string _brand;
        public Netbook(string brand) => _brand = brand;
        public void ShowDetails() => Console.WriteLine($"Netbook від {_brand}");
    }
}
