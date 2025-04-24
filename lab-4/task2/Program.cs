using task2.Mediators;
using task2.Models;

class Program
{
    static void Main()
    {
        var runway1 = new Runway();
        var runway2 = new Runway();

        CommandCentre commandCentre = new CommandCentre(
            new[] { runway1, runway2 },
            new Aircraft[] { }
        );

        var aircraft1 = new Aircraft("Boeing 737", commandCentre);
        var aircraft2 = new Aircraft("Airbus A320", commandCentre);

        commandCentre = new CommandCentre(
            new[] { runway1, runway2 },
            new[] { aircraft1, aircraft2 }
        );

        aircraft1.RequestLanding();
        aircraft2.RequestLanding();

        aircraft1.RequestTakeOff();
        aircraft2.RequestTakeOff();
    }
}