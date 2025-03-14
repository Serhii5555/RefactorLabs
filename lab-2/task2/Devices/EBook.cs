using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Devices
{
    class EBook : IDevice
    {
        private string _brand;
        public EBook(string brand) => _brand = brand;
        public void ShowDetails() => Console.WriteLine($"EBook від {_brand}");
    }
}
