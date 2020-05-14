using BoDi;
using System;
using System.Collections.Generic;
using System.Text;
using MarsFrame.Config;

namespace MarsFrame.Base
{
    public class InitFrameworkHook
    {
        
        public void InitFramework(IObjectContainer objectContainer)
        {
            _ = new InitConfig();
            _ = new WebDriverContext(objectContainer);
            _ = new ExtendReportContext();


        }
    }
}
