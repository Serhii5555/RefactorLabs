using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5.Builders;
using task5.Models;

namespace task5.Director
{
    class CharacterDirector
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder.SetName("Smith")
                          .SetHeight(180)
                          .SetBodyType("Athletic")
                          .SetHairColor("Blonde")
                          .SetEyeColor("Blue")
                          .SetOutfit("Knight Armor")
                          .AddToInventory("Sword")
                          .AddAbility("Giga detonator")
                          .Build();
        }

        public Character CreateEnemy(ICharacterBuilder builder)
        {
            return builder.SetName("George Droid")
                          .SetHeight(250)
                          .SetBodyType("Fat")
                          .SetHairColor("Black")
                          .SetEyeColor("Red")
                          .SetOutfit("Suit")
                          .AddToInventory("Staff of Doom")
                          .AddAbility("Lazer beams")
                          .Build();
        }
    }
}
