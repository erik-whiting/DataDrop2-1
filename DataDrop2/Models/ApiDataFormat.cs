using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2.Models
{
    class ApiDataFormat : DataFormat
    {
        public ApiDataFormat() : base() { }

        public override object ToDataFormat()
        {
            throw new NotImplementedException();
        }

        public override void WriteToFile(string directoryLocation, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
