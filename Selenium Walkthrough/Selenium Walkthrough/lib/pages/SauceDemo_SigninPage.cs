using OpenQA.Selenium;
using Selenium_Walkthrough.utitlities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Walkthrough.lib.pages
{
    public class SauceDemo_SigninPage
    {
        public SauceDemo_SigninPage(IWebDriver driver)
        {
            Driver = driver;
        }

        #region properties
        public IWebDriver Driver { get; }
        private string _url = AppConfigReader.SigninPageUrl;
        private IWebElement _userNameField => Driver.FindElement(By.Id("user-name"));
        private IWebElement _passwordField => Driver.FindElement(By.Id("password"));
        private IWebElement _loginButton => Driver.FindElement(By.Id("login-button"));
        private IWebElement _errorMessage => Driver.FindElement(By.ClassName("error-message-container"));
        #endregion

        #region Methods
        public void VisitSigninPage() => Driver.Navigate().GoToUrl(_url);
        public void InputUserName(string username) => _userNameField.SendKeys(username);
        public void InputPassword(string password) => _passwordField.SendKeys(password);
        public void ClickSignin() => _loginButton.Click();
        public string GetErrorText() => _errorMessage.Text;

        public void InputSigninCredentials(Credentials credentials)
        {
            _userNameField.SendKeys(credentials.Username);
            _passwordField.SendKeys(credentials.Password);
        }
        #endregion
    }
}
