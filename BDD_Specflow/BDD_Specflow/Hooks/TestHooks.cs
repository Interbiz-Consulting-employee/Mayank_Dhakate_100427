using TechTalk.SpecFlow;
using System;

namespace BDDDemo.Hooks
{
    [Binding]
    public class TestHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Test Start ");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine(" Test End");
        }
    }
}