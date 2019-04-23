using DataDrop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDrop2.Interfaces;

namespace DataDrop2
{
    public abstract class DataFormat : ITransformations
    {
        public List<DataPoint> DataPoints { get; set; }

        public abstract object ToDataFormat();
        public abstract void WriteToFile(string directoryLocation, string fileName);

        public DataFormat() { }

        public List<DataPoint> GetSelectedDataPoints()
        {
            return DataPoints.Where(x => x.Keep == true).ToList();
        }

        
    }
}
