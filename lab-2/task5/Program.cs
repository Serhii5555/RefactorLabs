using task5.Builders;
using task5.Models;
using task5.Director;

class Program
{
    static void Main()
    {
        CharacterDirector director = new();
        Character hero = director.CreateHero(new HeroBuilder());
        Character enemy = director.CreateEnemy(new EnemyBuilder());

        Console.WriteLine("Hero:\n" + hero);
        Console.WriteLine("\nEnemy:\n" + enemy);
    }
}