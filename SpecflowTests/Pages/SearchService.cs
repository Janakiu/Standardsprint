using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using NUnit.Framework;
using Newtonsoft.Json;
using MarsFrame.Extension;

namespace SpecflowTests.Pages
{
    public class SearchService : BasePage
    {
        private readonly IWebDriver Driver;

        public SearchService(IWebDriver driver)
        {
            this.Driver = driver;
        }
        #region Initialize the WebElements

        IWebElement searchPage => Driver.WaitForElement(By.Id("service-search-section"));

        IWebElement skillResult => Driver.WaitForElement(By.ClassName("search-results"));

        IList<IWebElement> Categories => Driver.FindElements(By.XPath("//section[@class='search-results']/descendant::div[@class='ui link list']/a"));
        
        //IList<IWebElement> Categories => Driver.FindElements(By.XPath("//h3[contains(text(),'Categories']"));
        
        IList <IWebElement> ResultList => Driver.FindElements(By.XPath("//section[@class='search-results']/descendant::div[@class='ui stackable three cards']/div[@class='ui card']"));

        IWebElement ResultMessage => Driver.FindElement(By.XPath("//section[@class='search-results']/descendant::div[@class='twelve wide column']//div[@class='ui grid']"));
        #endregion Initialized WebElements

        public void VerifyCategorySearch(string cat, int index)
        {
            Driver.wait(20);
            bool active = false;
            bool resultStatus = false;

            if (skillResult.Displayed && skillResult.Enabled)
            {
                // First the url
                var currentUrl = Driver.Url;
                string expectedURL = "http://localhost:5000/Home/Search?cat=" + cat.Replace(" ", "");

                /*// correct index presernt into searchPage arttribute in the list:            
                var jsonString = searchPage.GetAttribute("data-search-terms");
                var attribute = jsonString.Contains("categoryIndex:'" + index + "' ");
                Console.WriteLine(attribute);
                */

                // Active category
                foreach (var ele in Categories)
                {
                    if (ele.GetAttribute("class").Contains("active"))
                    {
                        active = true;
                        break;
                    }
                    Console.WriteLine("Element {0} with class attributes {1}", ele, ele.GetAttribute("class"));

                }
                // Check the search result
                //Console.WriteLine(ResultMessage.FindElement(By.TagName("h3")).Text);
                if (ResultList.Count > 0)
                {

                    resultStatus = true;
                }
                else if (ResultList.Count == 0)
                {
                    resultStatus = ResultMessage.FindElement(By.TagName("h3")).Text.Equals("No results found, please select a new category!");
                }

                // Assertions
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(expectedURL, currentUrl);
                    Assert.AreEqual(true, active);
                    Assert.AreEqual(true, resultStatus);
                });

            }
            else
            {
                Console.WriteLine("Element is not loaded yet");
            }

        }
    }
}















        

