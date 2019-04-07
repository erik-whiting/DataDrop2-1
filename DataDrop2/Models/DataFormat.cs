using DataDrop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2
{
    public abstract class DataFormat
    {
        public string DocumentType { get; set; }
        public string DataSource { get; set; }
        public bool IsSource { get; set; }
        public bool IsDestination { get; set; }
        public List<DataPoint> DataPoints { get; set; }

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
