using task2.Interfaces;

namespace task2.Items
{
    public class Sword : HeroDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " with Sword";
        public override int GetPower() => hero.GetPower() + 5;
    }
}
