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

        private string _url = AppConfigReader.InventoryPageUrl;

        private IWebElement _addCartButton => Driver.FindElement(By.ClassName("btn btn_primary btn_small btn_inventory"));

        private IWebElement _navigationMenuButton => Driver.FindElement(By.Id("react-burger-menu-btn"));

        private IWebElement _imagesBanner => Driver.FindElement(By.ClassName("inventory_item_img"));

        private IWebElement _priceText => Driver.FindElement(By.ClassName("inventory_item_price"));

        private IWebElement _shoppingCartLink => Driver.FindElement(By.ClassName("shopping_cart_link"));

        private IWebElement _filterButton => Driver.FindElement(By.ClassName("product_sort_container"));

        private IWebElement _appLogo => Driver.FindElement(By.ClassName("app_logo"));

        private IWebElement _appTitlePage => Driver.FindElement(By.ClassName("title"));

        private IWebElement _peekImage => Driver.FindElement(By.ClassName("peek")); 
    }
}
