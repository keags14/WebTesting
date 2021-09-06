using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Walkthrough.lib;
using Selenium_Walkthrough.lib.driver_config;
using Selenium_Walkthrough.lib.pages;

namespace Selenium_Walkthrough.tests
{
    class SauceDemo_Signin_Test
    {
        private SauceDemo_Website<ChromeDriver> _website = new SauceDemo_Website<ChromeDriver>();

        [OneTimeTearDown]
        public void CleanUp()
        {
            _website.Driver.Quit();
            _website.Driver.Dispose();
        }

        [Test]
        [Category("Sad")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheUsernameAndWrongPassword_ThenIGetAnErorMessage()
        {
            //Arrange
            //maximum the browser (full screen)
            _website.SignInPage.VisitSigninPage();
            //navigate to the Automation Practice site
            _website.SignInPage.InputUserName("standard_user");
            //click the password field
            _website.SignInPage.InputPassword("sauce");

            _website.SignInPage.ClickSignin();
            //Verify error message
            Assert.That(_website.SignInPage.GetErrorText(), Does.Contain("Epic sadface: Username and password do not match any user in this service"));
        }

        [Test]
        [Category("Sad")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheSigInLink_ThenIGettoMainHomepage()
        {
            //Arrange
            //maximum the browser (full screen)
            _website.SignInPage.VisitSigninPage();
            //get the signin link
            _website.SignInPage.InputUserName("standard_user");
            _website.SignInPage.InputPassword("secret");

            _website.SignInPage.ClickSignin();
            // wait to ensure a response
            Thread.Sleep(5000);
            //Assert that we are on the signing page
            Assert.That(_website.SignInPage.GetErrorText, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }

        [Test]
        [Category("Sad")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheUsernameWrongAndWrongPassword_ThenIGetAnErorMessage()
        {
            //Arrange
            //maximum the browser (full screen)
            _website.SignInPage.VisitSigninPage();
            //get the signin link
            _website.SignInPage.InputUserName("");
            _website.SignInPage.InputPassword("");
            
            _website.SignInPage.ClickSignin();
            // wait to ensure a response
            Thread.Sleep(5000);
            //Assert that we are on the signing page
            Assert.That(_website.SignInPage.GetErrorText, Is.EqualTo("Epic sadface: Username is required"));
        }

        [Test]
        [Category("Sad")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheLockeOutUserUsernameAndPassword_ThenIGetAnErorMessage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                _website.SignInPage.VisitSigninPage();

                //actx
                //click the signin  link
                _website.SignInPage.InputUserName("locked_out_user");
                _website.SignInPage.InputPassword("secret_sauce");
                _website.SignInPage.ClickSignin();
                // wait to ensure a response
                Thread.Sleep(5000);
                //Assert that we are on the signing page
                Assert.That(_website.SignInPage.GetErrorText, Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
            }
        }

        [Test]
        [Category("Sad")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheProblemUserUsernameAndPassword_ThenIDIrectedtoMainPageWithDogImages()
        {
            //Arrange
            _website.SignInPage.VisitSigninPage();

            //actx
            //click the signin  link
            _website.SignInPage.InputUserName("problem_user");
            _website.SignInPage.InputPassword("secret_sauce");
            _website.SignInPage.ClickSignin();
            // wait to ensure a response
            Thread.Sleep(5000);
            //Assert that we are on the signing page
            var image = _website.HomePage.Driver;
            Assert.That(image.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
            //Todo
            //Assert.That(image.GetAttribute(), );
        }

        [Test]
        [Category("Happy")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheUsernameAndPasswordIsRight_ThenIGetToTheMainPage()
        {
            //Arrange
            //maximum the browser (full screen)
            _website.SignInPage.VisitSigninPage();
            //navigate to the Automation Practice site
            _website.SignInPage.InputUserName("standard_user");
            _website.SignInPage.InputPassword("secret_sauce");
            
            _website.SignInPage.ClickSignin();
            // wait to ensure a response
            Thread.Sleep(5000);
            //Assert that we are on the signing page
            //driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");
            //Assert.That(_website.SignInPage.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }
    }
    
}
