using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowTests.Pages
{
    public class BasePage
    {
        public T As<T>() where T : BasePage {
            return (T)this;

        }
    
    }
}
