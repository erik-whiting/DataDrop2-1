using System;
using System.IO;
using DataDrop2.Methods;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataDrop2.Models
{
    class XMLDataFormat : DataFormat
    {
        public override object ToDataFormat()
        {
            string xmlString = "<?xml version='1.0' encoding='UTF-8'?>";
            xmlString += "<root>";
            var attributes = HelperMethods.GetAttributes(DataObjects);

            foreach(var dataObject in DataObjects)
            {
                xmlString += "<object>";
                foreach(var attr in attributes)
                {
                    foreach (var pair in dataObject.DataPairs)
                    {
                        xmlString += "<" + attr + ">";
                        xmlString += pair[attr];
                        xmlString += "</" + attr + ">";
                    }   
                }
                xmlString += "</object>";
            }
            xmlString += "</root>";
            xmlString = xmlString.Replace("'", "\"");
            return xmlString;
        }

        public override void WriteToFile(string directoryLocation, string fileName)
        {
            string filePath = directoryLocation + "\\" + fileName;
            var xmlData = ToDataFormat().ToString();
            using (StreamWriter file = new StreamWriter(filePath))
            {
                file.WriteLine(xmlData);
            }
        }

        public XMLDataFormat() : base() { }
    }
}
