using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2.Methods
{
    class AttributesFromJson
    {
        public static List<Dictionary<string, string>> GetJsonAttributes(string fileLocation)
        {
            JsonSerializer serializer = new JsonSerializer();
            var response = new List<Dictionary<string, string>>();
            
            var loadedJson = new LoadJSON(fileLocation);
            foreach (var jobject in loadedJson.JsonObjects)
            {
                var itemDict = new Dictionary<string, string>();
                foreach (var item in jobject)
                {
                    itemDict.Add(item.Key, item.Value.ToString());
                }
                response.Add(itemDict);
            }

            return response;
        }
    }
}
