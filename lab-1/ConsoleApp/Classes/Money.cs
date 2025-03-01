using ConsoleApp.Interfaces;

namespace ConsoleApp.Classes
{
    public class Money : IMoney
    {
        public int WholePart { get; private set; }
        public int Cents { get; private set; }

        public Money(int wholePart, int cents)
        {
            WholePart = wholePart;
            Cents = cents;
        }

        public void SetValue(int wholePart, int cents)
        {
            WholePart = wholePart;
            Cents = cents;
        }

        public override string ToString()
        {
            return $"{WholePart}.{Cents:00}";
        }
    }
}
