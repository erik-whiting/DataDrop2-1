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
        public string JsonString { get; set; }
        public List<JObject> JsonObjects { get; set; }
        public JArray JArray { get; set; }
        public LoadJSON(string fileLocation)
        {
            using (StreamReader r = new StreamReader(fileLocation))
            {
                JsonObjects = new List<JObject>();
                string fileContents = r.ReadToEnd();
                JsonSerializer serializer = new JsonSerializer();
                //JsonObject = JObject.Parse(fileContents);
                JArray = JArray.Parse(fileContents);
                foreach (var j in JArray)
                {
                    var jObject = JObject.Parse(j.ToString());
                    JsonObjects.Add(jObject);
                }
                
            }
        }
    }
}
