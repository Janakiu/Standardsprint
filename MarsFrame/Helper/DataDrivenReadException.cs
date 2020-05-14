using System;
using System.Collections.Generic;
using System.Text;

namespace MarsFrame.Helper
{
    public class DataDrivenReadException: Exception
    {
        
        public DataDrivenReadException(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}
