using task3;

class Program
{
    static void Main()
    {
        Thread t1 = new Thread(() => Console.WriteLine(Authenticator.Instance.GetHashCode()));
        Thread t2 = new Thread(() => Console.WriteLine(Authenticator.Instance.GetHashCode()));

        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
    }
}