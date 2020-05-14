using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsFrame.Helper
{
    public class CategoryTable
    {

        public string CategoryName { get; set; }

        public string CategoryIndex { get; set; }

    }
    // This is used for the vertical table data eg: |username| Janaki|
    /*    public class TableExtension
        {
            public static Dictionary<string, string> ToDictionary(Table table)
            {
                var dictionary = new Dictionary<string, string>();
                foreach (var row in table.Rows)
                {
                    dictionary.Add(row[0], row[1]);
                }
                return dictionary;
            }
        }*/

}







