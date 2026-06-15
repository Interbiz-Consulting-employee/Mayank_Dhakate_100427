using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDD_Specflow.StepDefinitions
{
    internal class calculatorsteps
    {
        [Binding]
        public class CalculatorSteps
        {
            private List<int> numbers = new List<int>();
            private int result;

            [Given(@"I enter (.*)")]
            public void GivenIEnter(int number)
            {
                numbers.Add(number);
            }

            [When(@"I press add")]
            public void WhenIPressAdd()
            {
                result = numbers.Sum();
            }

            [Then(@"result should be (.*)")]
            public void ThenResultShouldBe(int expected)
            {
                Assert.AreEqual(expected, result);
            }
        }
    }
}
