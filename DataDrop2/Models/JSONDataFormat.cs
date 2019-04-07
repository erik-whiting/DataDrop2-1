using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2.Models
{
    class JSONDataFormat : DataFormat
    {
        public string Source { get; set; } //File or API

        public JSONDataFormat(string documentType, bool isSource, bool isDestination) 
            : base(documentType, isSource, isDestination)
        {

        }
    }
}
