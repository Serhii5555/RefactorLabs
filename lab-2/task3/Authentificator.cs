using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class Authenticator
    {
        private static readonly Lazy<Authenticator> instance =
            new Lazy<Authenticator>(() => new Authenticator(), LazyThreadSafetyMode.ExecutionAndPublication);

        private Authenticator() { }

        public static Authenticator Instance => instance.Value;

        public void Authenticate()
        {
            Console.WriteLine("User authenticated: " + GetHashCode());
        }
    }
}
