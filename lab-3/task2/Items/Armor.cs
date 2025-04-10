using task2.Interfaces;

namespace task2.Items
{
    public class Armor : HeroDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " with Armor";
        public override int GetPower() => hero.GetPower() + 3;
    }
}
