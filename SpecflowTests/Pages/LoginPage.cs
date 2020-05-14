using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SpecflowTests.Config;
using MarsFrame.Extension;
using System.Threading;
using NUnit.Framework;



namespace SpecflowTests.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver Driver;

        public LoginPage(IWebDriver driver)
        {

            this.Driver = driver;
        }
        #region Initialize Web Elements

        private IWebElement SignIntab => Driver.WaitForElement(By.XPath("//a[contains(text(),'Sign In')]"));

        // private IWebElement Email => Driver.WaitForElement(By.XPath("//input[@name='email']"));
        private IWebElement Email => Driver.WaitForElement(By.Name("email"));
       // private IWebElement Password => Driver.FindElement(By.XPath("//input[@name='password']"));
        private IWebElement Password => Driver.WaitForElement(By.Name("password"));
        private IWebElement LoginBtn => Driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));

        #endregion

        //login to the website

        public void LoginWebsite(string email, string password)
        {

            //Driver.Navigate().GoToUrl(MarsFrame.Config.Settings.DockerBaseURL);
            Driver.Navigate().GoToUrl("http://localhost:5000/");
            //Thread.Sleep(1500);
            //SignIntab.Click();
            Email.SendKeys("janakiu3@gmail.com");
            Password.SendKeys("w1nner");
            LoginBtn.Click();
            //Assert.AreEqual("Log", "Login");
        }







    }
}
