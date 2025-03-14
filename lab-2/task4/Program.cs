using task4;

class Program
{
    static void Main()
    {
        Virus parent = new Virus("Alpha", "Corona", 0.01, 2);
        Virus child1 = new Virus("Beta", "Corona", 0.008, 1);
        Virus child2 = new Virus("Gamma", "Corona", 0.007, 1);
        Virus grandchild = new Virus("Delta", "Corona", 0.005, 0);

        child1.AddChild(grandchild);
        parent.AddChild(child1);
        parent.AddChild(child2);

        Console.WriteLine("Original Family:");
        parent.Display();

        Virus clonedFamily = (Virus)parent.Clone();

        Console.WriteLine("\nCloned Family:");
        clonedFamily.Display();
    }
}