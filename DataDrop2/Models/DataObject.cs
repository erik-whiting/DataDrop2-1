using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2.Models
{
    public class DataObject
    {
        public List<Dictionary<string, string>> DataPairs { get; set; }

        public DataObject()
        {
            DataPairs = new List<Dictionary<string, string>>();
        }

    }
}
