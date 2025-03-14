using task1.Creators;
using task1.Fabric;
using task1.Interfaces;

class Program
{
    static void Main()
    {
        SubscriptionFactory website = new WebSite();
        SubscriptionFactory mobileApp = new MobileApp();
        SubscriptionFactory managerCall = new ManagerCall();

        ISubscription domestic = website.CreateSubscription();
        ISubscription educational = mobileApp.CreateSubscription();
        ISubscription premium = managerCall.CreateSubscription();

        Console.WriteLine(domestic);
        Console.WriteLine();
        Console.WriteLine(educational);
        Console.WriteLine();
        Console.WriteLine(premium);
    }
}