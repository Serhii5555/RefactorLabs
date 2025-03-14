using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Classes.Subscriptions
{
    class DomesticSubscription : Subscription
    {
        public override string Name => "Domestic Subscription";
        public override double MonthlyFee => 10.99;
        public override int MinPeriod => 6;
        public override List<string> Channels => new List<string> { "News", "Entertainment", "Sports" };
        public override List<string> Features => new List<string> { "HD Quality" };
    }
}
