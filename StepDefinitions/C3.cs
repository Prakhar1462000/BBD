using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class C3
    {
        [Before] //pre
        public void setup()
        {
            Console.WriteLine("Setup*****");
        }
        [After] // post
        public void Teardown()
        {
            Console.WriteLine("After*****");
        }
    }
}
