using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5.Models
{
    class Character
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Outfit { get; set; }
        public List<string> Inventory { get; set; } = new();
        public List<string> Abilities { get; set; } = new();

        public override string ToString()
        {
            return $"Name: {Name}\nHeight: {Height} cm\nBody Type: {BodyType}\nHair Color: {HairColor}\nEye Color: {EyeColor}\nOutfit: {Outfit}\nInventory: {string.Join(", ", Inventory)}\nActions: {string.Join(", ", Abilities)}";
        }
    }
}
