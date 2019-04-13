using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace DataDrop2.Models
{
    class ExcelDataFormat : DataFormat
    {
        object misvalue = System.Reflection.Missing.Value;

        public override object ToDataFormat()
        {
            throw new NotImplementedException();
        }

        public override void WriteToFile(string directoryLocation, string fileName)
        {
            string filePath = directoryLocation + "\\" + fileName;




        }

        public ExcelDataFormat(string dataType)
            : base(dataType)
        {

        }

    }
}
