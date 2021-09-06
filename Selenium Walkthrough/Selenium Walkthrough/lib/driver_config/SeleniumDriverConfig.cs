using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Walkthrough.lib.driver_config
{
    public class SeleniumDriverConfig<T> where T : IWebDriver, new()
    {
        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver = new T();
            DriverSetUp(pageLoadInSecs, implicitWaitInSecs);
        }

        private void DriverSetUp(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }
    }
}
