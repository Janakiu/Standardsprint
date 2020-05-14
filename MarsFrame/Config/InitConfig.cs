using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using MarsFrame.Helper;


namespace MarsFrame.Config
{
    public class InitConfig
    {
        public InitConfig()
        {
            //json file path
            var jsonfile = PathHelper.GetCurrentPath("Config/config.json");
            using (StreamReader reader = new StreamReader(jsonfile))
            {
                var json = reader.ReadToEnd();
                JsonConvert.DeserializeObject<Settings>(json);

            }

        }
    
    }
}
