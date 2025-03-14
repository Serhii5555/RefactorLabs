using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Interfaces;

namespace task1.Classes
{
    abstract class Subscription : ISubscription
    {
        public abstract string Name { get; }
        public abstract double MonthlyFee { get; }
        public abstract int MinPeriod { get; }
        public abstract List<string> Channels { get; }
        public abstract List<string> Features { get; }

        public override string ToString()
        {
            return $"{Name}: {MonthlyFee}$/month, Min {MinPeriod} months\nChannels: {string.Join(", ", Channels)}\nFeatures: {string.Join(", ", Features)}";
        }
    }
}
