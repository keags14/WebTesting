using OpenQA.Selenium;
using Selenium_Walkthrough.lib.pages;
using Selenium_Walkthrough.lib.driver_config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Walkthrough.lib
{
    public class SauceDemo_Website<T> where T : IWebDriver, new()
    {
        #region Page Object and Driver
        public IWebDriver Driver { get; set; }
        public SauceDemo_HomePage HomePage { get; set; }
        public SauceDemo_SigninPage SignInPage { get; set; }
        #endregion

        public SauceDemo_Website(int pageLoadinSecs = 10, int implicitiWaitInSecs = 10)
        {
            Driver = new SeleniumDriverConfig<T>(pageLoadinSecs, implicitiWaitInSecs).Driver;
            HomePage = new SauceDemo_HomePage(Driver);
            SignInPage = new SauceDemo_SigninPage(Driver);
        }

        public void DeleteCookies() => Driver.Manage().Cookies.DeleteAllCookies();
    }
}
