using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestLoginFunctionalityStepDefinitions
    {
        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            Console.WriteLine("Test user on the login page");
        }

        [When(@"User enter the username and password")]
        public void WhenUserEnterTheUsernameAndPassword()
        {
            Console.WriteLine("Test user enter the username and password");
        }

        [When(@"User click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            Console.WriteLine("User click on the login button");
        }
        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
                Console.WriteLine("User is navigated to home page");
        }
    }
}
