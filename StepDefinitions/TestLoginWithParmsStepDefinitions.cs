using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestLoginWithParmsStepDefinitions
    {
        [When(@"User enter the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEnterTheAnd(string username, string password)
        {
            Console.WriteLine("The username is"+ username +".............."+ "The Password is " + password);
        }
        [Then(@"User selected city and country infomation")]
        public void ThenUserSelectedCityAndCountryInfomation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];

                Console.WriteLine(city + " , " + country);
            }
        }

    }
}
