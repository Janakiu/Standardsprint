using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using SpecflowTests.Pages;
using ScenarioContext = TechTalk.SpecFlow.ScenarioContext;


namespace SpecflowTests.Config
{
    public class Settings
    {
        // private ScenarioContext _scenarioContext

        [JsonProperty(PropertyName = "BaseUrl")]

        public static string BaseUrl { get; set; }

        [JsonProperty(PropertyName = "BaseUrl")]

        public static string DockerBaseURL { get; set; }

        [JsonProperty(PropertyName = "ExtendReportPath")]

        public static string ExtendReportPath { get; set; }

        /* // Initalize the current page
       private static BasePage _currentPage;

       //Get and set the current page
       public static BasePage currentPage {
           get { return _currentPage; }
           set
           {
               ScenarioContext.Current["class"] = value;
               ScenarioContext.Current.Get<BasePage>("class");
           }
       }*/



    }
}
