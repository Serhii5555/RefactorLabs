using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5.Models;

namespace task5.Builders
{
    interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHeight(int height);
        ICharacterBuilder SetBodyType(string bodyType);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetOutfit(string outfit);
        ICharacterBuilder AddToInventory(string item);
        ICharacterBuilder AddAbility(string action);
        Character Build();
    }
}
