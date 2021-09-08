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

        #region Properties
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

        private IWebElement _removeButton => Driver.FindElement(By.TagName("button")).FindElement(By.ClassName("btn btn_secondary btn_small btn_inventory"));
        #endregion

        #region Methods
        public void VisitHomePage() => Driver.Navigate().GoToUrl(_url);

        public bool GetFilterTextVisibility() => _filterButton.Displayed;

        public bool GetAddToCartTextVisibility() => _addCartButton.Displayed;

        public bool GetPriceTextVisibility() => _priceText.Displayed;

        public bool GetNavigationBarVisibility() => _navigationMenuButton.Displayed;

        public string GetRemoveText() => _removeButton.Text;

        public string GetAddToCartText() => _addCartButton.Text;

        public string GetPriceText() => _priceText.Text;
        #endregion
    }
}
