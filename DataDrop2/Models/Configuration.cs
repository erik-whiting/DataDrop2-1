using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2.Models
{
    class Configuration
    {
        public string MainDirectory { get; set; }

        public static string Directory()
        {
            return "C:\\Users\\eedee\\Documents";
        }
    }
}
