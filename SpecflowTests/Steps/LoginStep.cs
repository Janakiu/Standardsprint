using System;
using System.Text;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using OpenQA.Selenium;
using SpecflowTests.Pages;


namespace SpecflowTests.Steps
{
    [Binding]
    public class LoginStep
    {
        private readonly IWebDriver Driver;

        public LoginStep(IWebDriver driver)
        {
            this.Driver = driver;

        }

        [Given(@"I Login as trader")]
        public void GivenILoginAsTrader()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.LoginWebsite("", "");
        }
    }
}
