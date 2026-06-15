using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDPractise1
{
    namespace BDDPractise1
    {
        [Binding]
        public class LoginSteps
        {
            [Given(@"user is on login page")]
            public void GivenUserIsOnLoginPage()
            {
                Console.WriteLine("Navigated to login page");
            }

            [When(@"user enters username ""(.*)"" and password ""(.*)""")]
            public void WhenUserEntersUsernameAndPassword(string username, string password)
            {
                Console.WriteLine($"Entered Username: {username}, Password: {password}");
            }

            [Then(@"user should see the homepage")]
            public void ThenUserShouldSeeTheHomepage()
            {
                Console.WriteLine("Homepage is displayed");
            }
        }
    }
}
