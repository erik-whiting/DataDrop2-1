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
            List<Dictionary<string, string>> SerializableDataPoints = new List<Dictionary<string, string>>();

            foreach (var dp in DataPoints)
            {
                var SerializableDataPoint = new Dictionary<string, string>();
                SerializableDataPoint.Add(dp.Attribute, dp.Value);
                SerializableDataPoints.Add(SerializableDataPoint);
            }
            
            return JsonConvert.SerializeObject(SerializableDataPoints);
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
