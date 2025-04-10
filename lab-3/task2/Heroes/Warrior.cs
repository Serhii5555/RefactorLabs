using task2.Interfaces;

namespace task2.Heroes
{
    public class Warrior : IHero
    {
        public string GetDescription() => "Warrior";
        public int GetPower() => 10;
    }
}
