using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;

namespace DataDrop2.Methods
{
    class AttributesFromApi
    {
        public static List<Dictionary<string, string>> GetApiAttributes(string sourceUrl)
        {
            List<Dictionary<string, string>> response = new List<Dictionary<string, string>>();
            var client = new WebClient();
            var rawResponse = client.DownloadString(sourceUrl);
            var jsonResponse = JsonConvert.DeserializeObject(rawResponse);
            JObject jObject = JObject.Parse(jsonResponse.ToString());
            List<JToken> jList = new List<JToken>();
            foreach (var j in jObject.Values().ToArray()) jList.Add(j);

            foreach (var items in jList)
            {
                foreach (var item in items.Children<JObject>())
                {
                    var itemDict = new Dictionary<string, string>();
                    foreach (JProperty prop in item.Properties()) itemDict.Add(prop.Name, prop.Value.ToString());
                    response.Add(itemDict);
                }
            }
            return response;
        }
    }
}
