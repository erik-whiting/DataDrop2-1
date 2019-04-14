using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2.Models
{
    class DatabaseDataFormat : DataFormat
    {
        public string TableName { get; set; }
        public override object ToDataFormat()
        {
            var columns = DataPoints.Select(x => x.Attribute).Distinct();
            string InsertStatement = "INSERT INTO " + TableName + " (";
            foreach (var column in columns)
            {
                if (column != columns.Last())
                {
                    InsertStatement += column + ", ";
                }
                else
                {
                    InsertStatement += column;
                }
            }
            InsertStatement += ") VALUES" + Environment.NewLine;
            InsertStatement += "(";
            var valuesNum = DataPoints.Select(x => x.Attribute).Distinct().Count();
            var i = 1;
            foreach (var value in DataPoints)
            {      
                if (i == 1 || i % valuesNum != 0)
                {
                    InsertStatement += "\"" + value.Value + "\", ";
                    i++;
                }
                else
                {
                    if (value != DataPoints.Last())
                    {
                        InsertStatement += "\"" + value.Value + "\")," + Environment.NewLine;
                        InsertStatement += "(";
                        i++;
                    }
                    else
                    {
                        InsertStatement += "\"" + value.Value + "\")";
                    }

                }              
            }
            InsertStatement += ";";

            return InsertStatement;
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


        public DatabaseDataFormat(string dataType) 
            : base(dataType)
        {

        }
    }
}
