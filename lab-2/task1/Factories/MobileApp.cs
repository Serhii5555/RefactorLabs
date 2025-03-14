using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Classes.Subscriptions;
using task1.Fabric;
using task1.Interfaces;

namespace task1.Creators
{
    class MobileApp : SubscriptionFactory
    {
        public override ISubscription CreateSubscription()
        {
            return new EducationalSubscription();
        }
    }
}
