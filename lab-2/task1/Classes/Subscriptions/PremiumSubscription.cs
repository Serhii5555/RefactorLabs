using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Classes.Subscriptions
{
    class PremiumSubscription : Subscription
    {
        public override string Name => "Premium Subscription";
        public override double MonthlyFee => 19.99;
        public override int MinPeriod => 12;
        public override List<string> Channels => new List<string> { "All Channels" };
        public override List<string> Features => new List<string> { "4K Quality", "Multi-Device Support", "No Ads" };
    }
}
