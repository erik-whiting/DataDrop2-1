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
        public List<DataObject> DataObjects { get; set; }

        public abstract object ToDataFormat();
        public abstract void WriteToFile(string directoryLocation, string fileName);

        public DataFormat() { }
    }
}
