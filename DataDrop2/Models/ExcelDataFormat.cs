using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2.Models
{
    class ExcelDataFormat : DataFormat
    {
        object misvalue = System.Reflection.Missing.Value;
        

        public override object ToDataFormat()
        {
            Dictionary<string, object> ExcelWriteData = new Dictionary<string, object>();

            List<string[]> headerRow = new List<string[]>();
            string headers = "";
            var DpHeaders = DataPoints.Select(x => x.Attribute).Distinct().ToList();
            foreach (var dp in DpHeaders)
            {
                if (headers == "")
                {
                    headers += dp;
                }
                else
                {
                    headers += "," + dp;
                }
            }
            var headerArray = headers.Split(',');
            headerRow.Add(headerArray);
            string headerRange = "A1: " + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
            ExcelWriteData.Add("HeaderData", headerRow);
            ExcelWriteData.Add("HeaderRange", headerRange);

            string cellDataString = "";
            var cellData = new List<string[]>();
            foreach (var header in DpHeaders)
            {
                foreach (var dp in DataPoints.Where(x => x.Attribute == header))
                {
                    cellDataString += (cellDataString == "" ? dp.Value : "," + dp.Value); 
                }
                cellData.Add(cellDataString.Split(','));
                cellDataString = "";
            }
            

            ExcelWriteData.Add("CellData", cellData);

            return ExcelWriteData;
        }

        public override void WriteToFile(string directoryLocation, string fileName)
        {
            string filePath = directoryLocation + "\\" + fileName;
            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("DataDrop Worksheet");
                var dataSheet = excel.Workbook.Worksheets["DataDrop Worksheet"];

                var ExcelWriterData = (Dictionary<string, object>)ToDataFormat();
                var headerRow = (List<string[]>)ExcelWriterData["HeaderData"];
                var headerRange = (string)ExcelWriterData["HeaderRange"];
                var cellData = (List<string[]>)ExcelWriterData["CellData"];
                
                dataSheet.Cells[headerRange].LoadFromArrays(headerRow);
                int columnStart = 1;
                int rowStart = 2;

                for (int i = 0; i < cellData.Count; i++)
                {
                    var listItem = new List<object[]>();
                    var item = cellData[i];
                    listItem.Add(item);
                    //dataSheet.Cells[2, columnStart + i].LoadFromArrays(listItem);
                    for (int x = 0; x < item.Length; x++)
                    {
                        dataSheet.Cells[rowStart + x, columnStart + i].LoadFromText(item[x]);
                    }
                    

                }

                FileInfo excelFile = new FileInfo(filePath);
                excel.SaveAs(excelFile);
            }

        }

        public ExcelDataFormat(string dataType)
            : base(dataType)
        {

        }

    }
}
