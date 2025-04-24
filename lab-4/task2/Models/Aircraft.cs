using task2.Interfaces;

namespace task2.Models
{
    class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        private IAirTrafficMediator _mediator;

        public Aircraft(string name, IAirTrafficMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void RequestLanding()
        {
            Console.WriteLine($"Aircraft {Name} requesting to land.");
            _mediator.RequestLanding(this);
        }

        public void RequestTakeOff()
        {
            Console.WriteLine($"Aircraft {Name} requesting to take off.");
            _mediator.RequestTakeOff(this);
        }
    }
}
