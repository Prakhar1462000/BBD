using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Hook : Before Every Scenerio");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Hook : After Every Scenerio");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("Hook : Before Feature");
        }

        [AfterFeature]

        public static void AfterFeature()
        {
            Console.WriteLine("Hook : After Feature");
        }

        [BeforeScenario("Category A")]
        public void BeforeCategoryA()
        {
            Console.WriteLine("***********************************This will execute before category a TAGGED function");
        }
    }
}
