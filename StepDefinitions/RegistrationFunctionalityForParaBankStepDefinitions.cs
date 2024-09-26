using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class RegistrationFunctionalityForParaBankStepDefinitions
    {
        public IWebDriver driver;
        [Given(@"User is on Registration Page")]
        public void GivenUserIsOnRegistrationPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //Initialize web driver
            driver = new EdgeDriver();
            //Launch browser
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            //Maximize the window
            driver.Manage().Window.Maximize();

        }

        [When(@"User enters the ""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string FirstName, string LastName, string Address, string City, string State, string ZipCode, string Phone, string SSN, string UserName, string Password, string ConfirmPassword)
        {
            IWebElement Register = driver.FindElement(By.LinkText("Register"));
            Register.Click();

            Thread.Sleep(1000);

            IWebElement First = driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            First.SendKeys(FirstName);

            Thread.Sleep(1000);

            IWebElement Last = driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            Last.SendKeys(LastName);

            Thread.Sleep(1000);

            IWebElement Addrs = driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            Addrs.SendKeys(Address);

            Thread.Sleep(1000);

            IWebElement CityName = driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            CityName.SendKeys(City);

            Thread.Sleep(1000);

            IWebElement StateName = driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            StateName.SendKeys(State);

            Thread.Sleep(1000);

            IWebElement Zip = driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            Zip.SendKeys(ZipCode);

            Thread.Sleep(1000);

            IWebElement PhoneNo = driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            PhoneNo.SendKeys(Phone);

            Thread.Sleep(1000);

            IWebElement SSNNo = driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            SSNNo.SendKeys(SSN);

            Thread.Sleep(1000);

            IWebElement User = driver.FindElement(By.XPath("//input[@id='customer.username']"));
            User.SendKeys(UserName);

            Thread.Sleep(1000);

            IWebElement Pass = driver.FindElement(By.XPath("//input[@id='customer.password']"));
            Pass.SendKeys(Password);

            Thread.Sleep(1000);

            IWebElement CnfrmPasswrd = driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            CnfrmPasswrd.SendKeys(ConfirmPassword);

            Thread.Sleep(1000);
        }

        [When(@"User clicks on Register button")]
        public void WhenUserClicksOnRegisterButton()
        {
            IWebElement RegisterBtn = driver.FindElement(By.XPath("//input[@value='Register']"));
            RegisterBtn.Click();

            Thread.Sleep(1000);
        }

        [Then(@"User is navigated to Home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            IWebElement AccOverview = driver.FindElement(By.LinkText("Accounts Overview"));
            AccOverview.Click();

            Thread.Sleep(1000);
            driver.Close();
        }
    }
}