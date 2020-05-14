using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace MarsFrame.Extension
{
    public static class DriverExtensionMethods
    {
        public static void wait(this IWebDriver driver, int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

        }
        
        public static IWebElement WaitForElement(this IWebDriver driver, By ele, int timeOutSeconds = 10)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds));
                return (wait.Until(ExpectedConditions.ElementIsVisible(ele)));
            
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
                throw ex;
            }


        }
    
         public static void PageLoad(this IWebDriver driver, int timeOutinSeconds = 30)
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeOutinSeconds);
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
