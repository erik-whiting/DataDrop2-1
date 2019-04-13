using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Bytescout.Spreadsheet;

namespace DataDrop2.Methods
{
    class AttributesFromExcel
    {
        public static List<Dictionary<string, string>> GetExcelAttributes(string fileLocation)
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(fileLocation);
            var sheets = spreadsheet.Workbook.Worksheets;
            Bytescout.Spreadsheet.Worksheet sheet = spreadsheet.Workbook.Worksheets.ByName("Sheet1");
            var headerRange = sheet.UsedRangeColumnMax;
            var rowRange = sheet.UsedRangeRowMax;
            var headers = GetHeaders(sheet);
            var data = GetData(sheet, headers);

            return data;
        }

        private static List<string> GetHeaders(Bytescout.Spreadsheet.Worksheet ws)
        {
            List<string> headers = new List<string>();
            var headerRange = ws.UsedRangeColumnMax;
            for (int i = 0; i <= headerRange; i++)
            {
                headers.Add(ws.Cell(0, i).Value.ToString());
            }

            return headers;
        }

        private static List<Dictionary<string, string>> GetData(Bytescout.Spreadsheet.Worksheet ws, List<string> headers)
        {
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();

            for (int i = 1; i <= ws.UsedRangeRowMax; i++)
            {
                
                for (int x = 0; x < headers.Count; x++)
                {
                    var itemDict = new Dictionary<string, string>();
                    itemDict.Add(headers[x], ws.Cell(i, x).Value.ToString());
                    data.Add(itemDict);
                }
                
            }


            return data;
        }

    }
}
