using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DataDrop2.Models
{
    class JSONDataFormat : DataFormat
    {

        public override object ToDataFormat()
        {
            List<Dictionary<string, string>> SerializableDataObjects = new List<Dictionary<string, string>>();
            
            foreach (var dp in DataObjects)
            {
                foreach (var pair in dp.DataPairs) { SerializableDataObjects.Add(pair); }
            }
            
            return JsonConvert.SerializeObject(SerializableDataObjects);
        }

        public override void WriteToFile(string directoryLocation, string fileName)
        {
            string filePath = directoryLocation + "\\" + fileName;
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(filePath))
            {
                file.WriteLine(ToDataFormat());
            }
        }

        public JSONDataFormat() : base()
        {

        }
    }
}
