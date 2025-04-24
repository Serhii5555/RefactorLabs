using task2.Interfaces;
using task2.Models;

namespace task2.Mediators
{
    class CommandCentre : IAirTrafficMediator
    {
        private List<Runway> _runways = new();
        private List<Aircraft> _aircrafts = new();
        private Dictionary<Aircraft, Runway?> _assignments = new();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            _runways.AddRange(runways);
            _aircrafts.AddRange(aircrafts);
            foreach (var aircraft in aircrafts)
            {
                _assignments[aircraft] = null;
            }
        }

        public void RequestLanding(Aircraft aircraft)
        {
            var availableRunway = _runways.FirstOrDefault(r => r.IsFree);
            if (availableRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {availableRunway.Id}");
                availableRunway.OccupiedBy = aircraft;
                availableRunway.HighLightRed();
                _assignments[aircraft] = availableRunway;
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} cannot land – no runway available.");
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            if (_assignments.TryGetValue(aircraft, out var runway) && runway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {runway.Id}");
                runway.OccupiedBy = null;
                runway.HighLightGreen();
                _assignments[aircraft] = null;
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not assigned to any runway.");
            }
        }
    }
}
