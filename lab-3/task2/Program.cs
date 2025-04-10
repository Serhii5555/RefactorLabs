using task2.Heroes;
using task2.Interfaces;
using task2.Items;

public class Program
{
    public static void Main()
    {
        IHero hero1 = new Warrior();
        hero1 = new Sword(hero1);
        hero1 = new Armor(hero1);
        hero1 = new Artifact(hero1);

        Console.WriteLine(hero1.GetDescription());
        Console.WriteLine("Power: " + hero1.GetPower()); // 10 + 5 + 3 + 7 = 25

        IHero hero2 = new Mage();
        hero2 = new Artifact(hero2);
        hero2 = new Artifact(hero2); 

        Console.WriteLine(hero2.GetDescription()); 
        Console.WriteLine("Power: " + hero2.GetPower()); // 8 + 7 + 7 = 22

        IHero hero3 = new Paladin();
        hero3 = new Armor(new Sword(hero3));

        Console.WriteLine(hero3.GetDescription()); 
        Console.WriteLine("Power: " + hero3.GetPower()); // 9 + 5 + 3 = 17
    }
}