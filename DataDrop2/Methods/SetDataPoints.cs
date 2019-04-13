using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDrop2.Models;

namespace DataDrop2.Methods
{
    class SetDataPoints
    {
        public static List<DataPoint> Set(List<Dictionary<string, string>> AllValues, List<string> KeepValues)
        {
            var DataPoints = new List<DataPoint>();
            foreach (var val in AllValues)
            {
                if (KeepValues.Contains(val.First().Key))
                {
                    var x = val.First().Key;
                    var y = val.First().Value;

                    var dp = new DataPoint(
                        val.First().Key,
                        val.First().Value,
                        true
                        );
                    DataPoints.Add(dp);
                }
            }


            return DataPoints;
        }
    }
}
