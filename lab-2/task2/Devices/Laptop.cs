﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Devices
{
    class Laptop : IDevice
    {
        private string _brand;
        public Laptop(string brand) => _brand = brand;
        public void ShowDetails() => Console.WriteLine($"Laptop від {_brand}");
    }
}
