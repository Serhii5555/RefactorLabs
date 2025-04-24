namespace task2.Models
{
    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public Aircraft? OccupiedBy { get; set; }

        public bool IsFree => OccupiedBy == null;

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}
