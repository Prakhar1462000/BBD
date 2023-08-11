using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class C2
    {
        [Given(@"B")]
        public void GivenB()
        {
            Console.WriteLine("Printing B ");
        }

        [When(@"C")]
        public void WhenC()
        {
            Console.WriteLine("Printing C ");
        }

        [Then(@"D")]
        public void ThenD()
        {
            Console.WriteLine("Printing D ");
        }

        [Given(@"Open chrome")]
        public void GivenOpenChrome()
        {
            Console.WriteLine("Open Chrome");
            Console.WriteLine("******");
        }
        [Given(@"Open Firefox")]
        public void GivenOpenFirefox()
        {
            Console.WriteLine("Open FireFox");
            Console.WriteLine("******");
        }


    }
}
