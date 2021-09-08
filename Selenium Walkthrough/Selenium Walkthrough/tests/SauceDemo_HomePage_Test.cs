using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium_Walkthrough.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Walkthrough.tests
{
    class SauceDemo_HomePage_Test
    {
        #region Setup

        private SauceDemo_Website<ChromeDriver> _website = new SauceDemo_Website<ChromeDriver>();
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _website.SignInPage.VisitSigninPage();
            _website.SignInPage.InputUserName("standard_user");
            _website.SignInPage.InputPassword("secret_sauce");
            _website.SignInPage.ClickSignin();
        }
        #endregion

        #region Tests
        [Test]
        public void GivenIAmOnTheInventoryPage_ThereIsAFilterButton()
        {
            //Arrange
            _website.HomePage.VisitHomePage();

            Assert.That(_website.HomePage.GetFilterTextVisibility(), Is.True);
        }

        [Test]
        public void GivenIAmOnTheInventoryPage_ThereIsAnAddToCartButtonVisible()
        {
            //Arrange
            _website.HomePage.VisitHomePage();

            Assert.That(_website.HomePage.GetAddToCartTextVisibility(), Is.True);
        }

        [Test]
        public void GivenIAmOnTheInventoryPage_ThereIsAnAddToCartButton()
        {
            //Arrange
            _website.HomePage.VisitHomePage();

            Assert.That(_website.HomePage.GetAddToCartTextVisibility(), Is.EqualTo("Add to cart"));
        }

        [Test]
        public void GivenIAmOnTheInventoryPage_ThereIsAPriceDisplayedForTheItems()
        {
            //Arrange
            _website.HomePage.VisitHomePage();

            Assert.That(_website.HomePage.GetPriceText(), Is.EqualTo("$29.99"));
        }

        [Test]
        public void GivenIAmOnTheInventoryPage_ThereIsAPriceDisplayedForTheItemsWithVisibilityTrue()
        {
            //Arrange
            _website.HomePage.VisitHomePage();

            Assert.That(_website.HomePage.GetPriceTextVisibility(), Is.True);
        }

        [Test]
        public void GivenIAmOnTheInventoryPage_TheNavigationBarIsVisibleForTheUser()
        {
            //Arrange
            _website.HomePage.VisitHomePage();

            Assert.That(_website.HomePage.GetNavigationBarVisibility(), Is.True);
        }
        #endregion

        #region TearDown
        [OneTimeTearDown]
        public void CleanUp()
        {
            _website.Driver.Quit();
            _website.Driver.Dispose();
        }
        #endregion
    }
}
