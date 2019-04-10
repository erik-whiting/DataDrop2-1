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
        public string DocumentType { get; set; }
        public string DataSource { get; set; }
        public bool IsSource { get; set; }
        public bool IsDestination { get; set; }
        public List<DataPoint> DataPoints { get; set; }

        public abstract object ToDataFormat(List<DataPoint> dataPoints);

        public DataFormat(string documentType, bool isSource, bool isDestination)
        {
            DocumentType = documentType;
            IsSource = isSource;
            IsDestination = isDestination;
        }

        public List<DataPoint> GetSelectedDataPoints()
        {
            return DataPoints.Where(x => x.Keep == true).ToList();
        }

        
    }
}
