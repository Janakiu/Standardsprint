using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports.Reporter;
using MarsFrame.Helper;
using MarsFrame.Config;

namespace MarsFrame.Base
{
    public class ExtendReportContext
    {
        public static AventStack.ExtentReports.ExtentReports ExtentReport { get; set; }
        public ExtendReportContext()
        {
            ExtentReport = new AventStack.ExtentReports.ExtentReports();
            // store the Report
            var path = PathHelper.GetCurrentPath(Settings.ExtendReportPath);
            var htmlReporter = new ExtentHtmlReporter(path);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            ExtentReport.AttachReporter(htmlReporter);



        }
    }
}
