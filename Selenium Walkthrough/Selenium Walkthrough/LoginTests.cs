using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Walkthrough
{
    public class LoginTests
    {
       /* [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSignInLink_ThenIGoToTheSigninPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Arrange
                //maximum the browser (full screen)
                driver.Manage().Window.Maximize();
                //navigate to the Automation Practice site
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
                //get the signin link
                IWebElement signinLink = driver.FindElement(By.LinkText("Sign in"));
                //act
                //click the signin  link
                signinLink.Click();
                // wait to ensure a response
                Thread.Sleep(5000);
                //Assert that we are on the signing page
                Assert.That(driver.Title, Is.EqualTo("Login - My Store"));
            }
        }*/

        [Test]
        [Category("Sad")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheSigInLink_ThenIGettoMainHomepage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Arrange
                //maximum the browser (full screen)
                driver.Manage().Window.Maximize();
                //navigate to the Automation Practice site
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                //get the signin link
                IWebElement username = driver.FindElement(By.Id("user-name"));
                IWebElement password = driver.FindElement(By.Id("password"));

                IWebElement button = driver.FindElement(By.Id("login-button"));
                //actx
                //click the signin  link
                username.SendKeys("standard_user");
                password.SendKeys("secret");
                button.Submit();
                // wait to ensure a response
                Thread.Sleep(5000);
                //Assert that we are on the signing page
                IWebElement errorMessage = driver.FindElement(By.ClassName("error-button"));
                Assert.That(errorMessage.Displayed, Is.True);
            }
        }

        [Test]
        [Category("Sad")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheUsernameAndWrongPassword_ThenIGetAnErorMessage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Arrange
                //maximum the browser (full screen)
                driver.Manage().Window.Maximize();
                //navigate to the Automation Practice site
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                //get the signin link
                IWebElement username = driver.FindElement(By.Id("user-name"));
                IWebElement password = driver.FindElement(By.Id("password"));

                IWebElement button = driver.FindElement(By.Id("login-button"));
                //actx
                //click the signin  link
                username.SendKeys("standard_user");
                password.SendKeys("secret");
                button.Submit();
                // wait to ensure a response
                Thread.Sleep(5000);
                //Assert that we are on the signing page
                IWebElement errorMessage = driver.FindElement(By.CssSelector("h3"));
                Assert.That(errorMessage.Text, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
            }
        }

        [Test]
        [Category("Sad")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheUsernameWrongAndWrongPassword_ThenIGetAnErorMessage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Arrange
                //maximum the browser (full screen)
                driver.Manage().Window.Maximize();
                //navigate to the Automation Practice site
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                //get the signin link
                IWebElement username = driver.FindElement(By.Id("user-name"));
                IWebElement password = driver.FindElement(By.Id("password"));

                IWebElement button = driver.FindElement(By.Id("login-button"));
                //actx
                //click the signin  link
                username.SendKeys("");
                password.SendKeys("");
                button.Submit();
                // wait to ensure a response
                Thread.Sleep(5000);
                //Assert that we are on the signing page
                IWebElement errorMessage = driver.FindElement(By.CssSelector("h3"));
                Assert.That(errorMessage.Text, Is.EqualTo("Epic sadface: Username is required"));
            }
        }

        [Test]
        [Category("Sad")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheLockeOutUserUsernameAndPassword_ThenIGetAnErorMessage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Arrange
                //maximum the browser (full screen)
                driver.Manage().Window.Maximize();
                //navigate to the Automation Practice site
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                //get the signin link
                IWebElement username = driver.FindElement(By.Id("user-name"));
                IWebElement password = driver.FindElement(By.Id("password"));

                IWebElement button = driver.FindElement(By.Id("login-button"));
                //actx
                //click the signin  link
                username.SendKeys("locked_out_user");
                password.SendKeys("secret_sauce");
                button.Submit();
                // wait to ensure a response
                Thread.Sleep(5000);
                //Assert that we are on the signing page
                IWebElement errorMessage = driver.FindElement(By.CssSelector("h3"));
                Assert.That(errorMessage.Text, Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
            }
        }

        [Test]
        [Category("Sad")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheProblemUserUsernameAndPassword_ThenIDIrectedtoMainPageWithDogImages()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Arrange
                //maximum the browser (full screen)
                driver.Manage().Window.Maximize();
                //navigate to the Automation Practice site
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                //get the signin link
                IWebElement username = driver.FindElement(By.Id("user-name"));
                IWebElement password = driver.FindElement(By.Id("password"));

                IWebElement button = driver.FindElement(By.Id("login-button"));
                //actx
                //click the signin  link
                username.SendKeys("problem_user");
                password.SendKeys("secret_sauce");
                button.Submit();
                // wait to ensure a response
                Thread.Sleep(5000);
                //Assert that we are on the signing page
                var image = driver.FindElement(By.ClassName("inventory_item_img")).GetAttribute("src");
                Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
                //Todo
                Assert.That(image, Is.EqualTo("https://www.saucedemo.com/static/media/sl-404.168b1cce.jpg"));
            }
        }

        [Test]
        [Category("Happy")]
        public void GivenIamOnTheSwagLabsWebsite_WhenIEnterTheUsernameAndPasswordIsRight_ThenIGetToTheMainPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Arrange
                //maximum the browser (full screen)
                driver.Manage().Window.Maximize();
                //navigate to the Automation Practice site
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                //get the signin link
                IWebElement username = driver.FindElement(By.Id("user-name"));
                IWebElement password = driver.FindElement(By.Id("password"));

                IWebElement button = driver.FindElement(By.Id("login-button"));
                //actx
                //click the signin  link
                username.SendKeys("standard_user");
                password.SendKeys("secret_sauce");
                button.Submit();
                // wait to ensure a response
                Thread.Sleep(5000);
                //Assert that we are on the signing page
                Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
            }
        }
    }
}
