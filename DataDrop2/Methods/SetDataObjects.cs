using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDrop2.Models;

namespace DataDrop2.Methods
{
    class SetDataObjects
    {
        public static List<DataObject> Set(List<Dictionary<string, string>> AllValues, List<string> KeepValues)
        {
            var DataObjects = new List<DataObject>();
            foreach (var val in AllValues)
            {
                var dataObj = new DataObject();
                var dict = new Dictionary<string, string>();
                foreach (var attr in KeepValues)
                {
                    dict.Add(attr, val[attr]);
                    //try
                    //{
                    //    dict.Add(attr, val[attr]);
                    //}
                    //catch (Exceptio)
                    //{

                    //}
                    //finally
                    //{

                    //}
                }
                dataObj.DataPairs.Add(dict);
                DataObjects.Add(dataObj);
            }
            
            return DataObjects;
        }
    }
}
