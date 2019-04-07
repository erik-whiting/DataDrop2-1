using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DataDrop2.Methods
{
    class LoadJSON
    {
        public JObject JsonObject { get; set; }
        public LoadJSON(string fileLocation)
        {
            using (StreamReader r = new StreamReader(fileLocation))
            {
                string fileContents = r.ReadToEnd();
                JsonSerializer serializer = new JsonSerializer();
                JsonObject = JObject.Parse(fileContents);
            }
        }
    }
}
