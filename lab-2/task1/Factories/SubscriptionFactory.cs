using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Interfaces;

namespace task1.Fabric
{
    abstract class SubscriptionFactory
    {
        public abstract ISubscription CreateSubscription();
    }
}
