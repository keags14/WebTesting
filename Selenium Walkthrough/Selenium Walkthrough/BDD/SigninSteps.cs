
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium_Walkthrough.lib;
using Selenium_Walkthrough.utitlities;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Selenium_Walkthrough.BDD
{
    [Binding]
    public class SigninSteps
    {
        private SauceDemo_Website<ChromeDriver> _website = new SauceDemo_Website<ChromeDriver>();
        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            _website.SignInPage.VisitSigninPage();
        }
        
        [Given(@"I have entered the username ""(.*)""")]
        public void GivenIHaveEnteredTheUsername(string username)
        {
            _website.SignInPage.InputUserName(username);
        }

        [Given(@"I have entered the password ""(.*)""")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            _website.SignInPage.InputPassword(password);
        }

        [Given(@"I have the following crednetials")]
        public void GivenIHaveTheFollowingCrednetials(Table table)
        {
            var credentials = table.CreateInstance<Credentials>();
            _website.SignInPage.InputSigninCredentials(credentials);
        }

        [Then(@"I should be directed to the homepage")]
        public void ThenIShouldBeDirectedToTheHomepage()
        {
            Assert.That(_website.Driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }


        [Then(@"I should see an error message ""(.*)""")]
        public void ThenIShoudlSeeAnErrorMessage(string message)
        {
            Assert.That(_website.SignInPage.GetErrorText(), Does.Contain(message));
        }

        [Then(@"The correct images is not displayed")]
        public void ThenTheCorrectImagesIsNotDisplayed()
        {
            Assert.That(_website.HomePage.get);
        }

        [Then(@"The pages take too long to load")]
        public void ThenThePagesTakeTooLongToLoad()
        {
            Assert.That(Thread.Sleep(3000), is.);
        }

        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            _website.SignInPage.ClickSignin();
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _website.Driver.Quit();
            _website.Driver.Dispose();
        }

    }
}
