using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDrop2.Methods;

namespace DataDrop2.Models
{
    class SqlDataFormat : DataFormat
    {
        public string TableName { get; set; }


        public override object ToDataFormat()
        {
            return HelperMethods.GenerateSqlInsert(DataObjects, TableName);
        }

        public override void WriteToFile(string directoryLocation, string fileName)
        {
            TableName = fileName.Split('.').First();
            string filePath = directoryLocation + "\\" + DateTime.Now.ToString("MM-dd-yyyy") + fileName;
            var InsertStatement = ToDataFormat();
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(filePath))
            {
                file.WriteLine(InsertStatement);
            }
        }


        public SqlDataFormat() : base() { }
    }
}
