using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowFrameworkDemo.Pages;
using SpecFlowFrameworkDemo.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowFrameworkDemo.Steps
{
    [Binding]
    class LoginSteps
    {
        LoginPage _loginPage = null;
        public LoginSteps(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
        }

        [Given(@"I launch the application")]
        public void GivenILaunchTheApllication()
        {
            //IWebDriver webDriver = new ChromeDriver();
            _loginPage.Navigate("http://leaftaps.com/opentaps/control/logout");
        }

        [Given(@"I enter the Username and Pasword")]
        public void GivenEnterUserNameandPassword()
        {
            var userData = ExcelDataReader.GetTestData("LoginTest");
            _loginPage.Login(userData.Username, userData.Password);
        }

        [Given(@"I click login button")]
        public void ClickLogin()
        {
            _loginPage.ClickLoginButton();
        }

        [Then(@"I should see CRM SFA link")]
        public void crmLink()
        {
            _loginPage.LinkTextisDisplayed().Should().BeTrue();
        }


        [Then(@"I Tap on CRM Link")]
        public void CliclcrmLink()
        {
            _loginPage.TaponCrmLink();
        }

        [Then(@"I should see Page Title as ""(.*)""")]
        public void ThenIShouldSeePageTitleAs(string title)
        {
            _loginPage.AssertTitle(title);
       }

    }
}
