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
            var columns = GetAttributes(DataObjects);
            
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
            foreach (var value in DataObjects)
            {
                foreach (var column in columns)
                {
                    foreach (var val in value.DataPairs)
                    {
                        if (column != columns.Last())
                        {
                            InsertStatement += "\"" + val[column] + "\", ";
                        }
                        else
                        {
                            if (value != DataObjects.Last())
                            {
                                InsertStatement += "\"" + val[column] + "\"),";
                                InsertStatement += Environment.NewLine + "(";
                            }
                            else
                            {
                                InsertStatement += "\"" + val[column] + "\")";
                            }
                            
                        }
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


        public DatabaseDataFormat() : base() { }
    }
}
