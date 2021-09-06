using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Walkthrough.lib.pages
{
    public class SauceDemo_HomePage
    {
        public SauceDemo_HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }
    }
}
