using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Devices
{
    class Smartphone : IDevice
    {
        private string _brand;
        public Smartphone(string brand) => _brand = brand;
        public void ShowDetails() => Console.WriteLine($"Smartphone від {_brand}");
    }
}
