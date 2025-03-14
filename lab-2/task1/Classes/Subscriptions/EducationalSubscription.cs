using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Classes.Subscriptions
{
    class EducationalSubscription : Subscription
    {
        public override string Name => "Educational Subscription";
        public override double MonthlyFee => 5.99;
        public override int MinPeriod => 3;
        public override List<string> Channels => new List<string> { "Discovery", "National Geographic", "History" };
        public override List<string> Features => new List<string> { "Ad-Free Viewing" };
    }
}
