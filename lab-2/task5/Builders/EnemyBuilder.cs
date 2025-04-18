﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5.Models;

namespace task5.Builders
{
    class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new();

        public ICharacterBuilder SetName(string name) { _character.Name = name; return this; }
        public ICharacterBuilder SetHeight(int height) { _character.Height = height; return this; }
        public ICharacterBuilder SetBodyType(string bodyType) { _character.BodyType = bodyType; return this; }
        public ICharacterBuilder SetHairColor(string hairColor) { _character.HairColor = hairColor; return this; }
        public ICharacterBuilder SetEyeColor(string eyeColor) { _character.EyeColor = eyeColor; return this; }
        public ICharacterBuilder SetOutfit(string outfit) { _character.Outfit = outfit; return this; }
        public ICharacterBuilder AddToInventory(string item) { _character.Inventory.Add(item); return this; }
        public ICharacterBuilder AddAbility(string action) { _character.Abilities.Add("Evil: " + action); return this; }
        public Character Build() { return _character; }
    }
}
