using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;
using MarsFrame.Config;
using SpecflowTests.Pages;
using MarsFrame.Helper;
using MarsFrame.Extension;


namespace SpecflowTests.Steps
{
    [Binding]
    public class ExploreCategorySteps
    {
        private readonly IWebDriver Driver;
       // private readonly IObjectContainer container;
        private Category category;
        private SearchService SearchService;

        public ExploreCategorySteps(IWebDriver driver)
        {
            this.Driver = driver;
            category = new Category(Driver);
        }
        
        [Given(@"I visit to Home page")]
        public void GivenIVisitToHomePage()
        {
            Driver.Navigate().GoToUrl(Settings.DockerBaseURL);
        }
        
        [Given(@"I scroll down to Explore category")]
        public void GivenIScrollDownToExploreCategory()
        {
            category.scrollDownToCategory();
        }

        /*   [When(@"I click on Category")]
           public void WhenIClickOnCategory(Table table)
           {
               var cat = table.CreateSet<CategoryTable>();
               SearchService = category.SearchCateory(cat.CategoryName);
           }*/

        [When(@"I click on Category (.*)")]
        public void WhenIClickOnCategory(string cat)
        {
            SearchService = category.SearchCategory(cat);
        }
        
        [Then(@"I should successfully view service per (.*) and (.*)")]
        public void ThenIShouldSuccessfullyViewServicePerGraphicDesignAnd(string cat, int index)
        {
            Thread.Sleep(50);
            SearchService.VerifyCategorySearch(cat, index);
            Thread.Sleep(50);
        }
    }
}
