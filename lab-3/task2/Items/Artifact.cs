using task2.Interfaces;

namespace task2.Items
{
    public class Artifact : HeroDecorator
    {
        public Artifact(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " with Artifact";
        public override int GetPower() => hero.GetPower() + 7;
    }
}
