﻿using task2.Interfaces;

namespace task2.Heroes
{
    public class Paladin : IHero
    {
        public string GetDescription() => "Paladin";
        public int GetPower() => 9;
    }
}
