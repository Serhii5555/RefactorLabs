using task2.Interfaces;

namespace task2.Heroes
{
    public class Mage : IHero
    {
        public string GetDescription() => "Mage";
        public int GetPower() => 8;
    }
}
