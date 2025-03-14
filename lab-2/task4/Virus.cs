using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Virus : ICloneable
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Species = species;
            Weight = weight;
            Age = age;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Virus clone = new Virus(Name, Species, Weight, Age);
            foreach (var child in Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }
            return clone;
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}Virus: {Name}, Species: {Species}, Weight: {Weight}, Age: {Age}");
            foreach (var child in Children)
            {
                child.Display(indent + "  ");
            }
        }
    }
}
