using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2.Models
{
    public class DataPoint
    {
        public string Attribute { get; set; }
        public string Value { get; set; }
        public bool Keep { get; set; }

        public DataPoint(string attribute, string value, bool keep=false)
        {
            Attribute = attribute;
            Value = value;
            Keep = keep;
        }

        public void ToggleKeep()
        {
            Keep = !Keep;
        }

    }
}
