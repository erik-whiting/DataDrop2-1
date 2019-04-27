using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DataDrop2.Methods
{
    class AttributesFromXML
    {
        public static List<Dictionary<string, string>> GetXMLAttributes(string fileLocation)
        {
            var response = new List<Dictionary<string, string>>();

            XmlDocument doc = new XmlDocument();
            doc.Load(fileLocation);
            XDocument docx = XDocument.Parse(doc.InnerXml);
            var itemDict = new Dictionary<string, string>();
            var test = docx.Descendants().Where(p => p.HasElements == false);
            foreach (XElement element in docx.Descendants().Where(p => p.HasElements == false))
            {
                string keyName = element.Name.LocalName;
                if (!itemDict.ContainsKey(keyName))
                {
                    itemDict.Add(keyName, element.Value);
                }
                else
                {
                    response.Add(itemDict);
                    
                    itemDict = new Dictionary<string, string>();
                    itemDict.Add(keyName, element.Value);
                }
                
            }
            response.Add(itemDict);
            return response;
        }

    }
}
