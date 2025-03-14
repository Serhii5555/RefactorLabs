using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Interfaces
{
    interface ISubscription
    {
        string Name { get; }
        double MonthlyFee { get; }
        int MinPeriod { get; }
        List<string> Channels { get; }
        List<string> Features { get; }
    }
}
