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

        #endregion

        #region TearDown

        #endregion
    }
}
