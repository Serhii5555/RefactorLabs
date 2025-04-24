using task2.Models;

namespace task2.Interfaces
{
    interface IAirTrafficMediator
    {
        void RequestLanding(Aircraft aircraft);
        void RequestTakeOff(Aircraft aircraft);
    }
}
