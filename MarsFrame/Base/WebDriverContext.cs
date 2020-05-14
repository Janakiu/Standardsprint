using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BoDi;

namespace MarsFrame.Base
{
    public class WebDriverContext
    {
        public IWebDriver Driver { get; set; }
        public static IObjectContainer _objectContainer;

        public WebDriverContext(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;

            Driver = new ChromeDriver();

            Driver.Manage().Window.Maximize();

            _objectContainer.RegisterInstanceAs(Driver);
        }
    
    
    }
}
