using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowFrameworkDemo.Pages
{
    class LoginPage : PageObjects
    {
        private readonly IWebDriver _driver;
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        public IWebElement LoginId => _driver.FindElement(By.Id("username"));
        public IWebElement Password => _driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => _driver.FindElement(By.ClassName("decorativeSubmit"));

        public IWebElement CRMLink => _driver.FindElement(By.LinkText("CRM/SFA"));

        public void Login(String UserName, string password)
        {
            LoginId.SendKeys(UserName);
            Password.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public bool LinkTextisDisplayed()
        {
            return CRMLink.Displayed;
        }
        public void TaponCrmLink()
        {
             CRMLink.Click();
        }




    }
}
