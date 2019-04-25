using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDrop2.Methods;

namespace DataDrop2.Models
{
    class DBDataFormat : DataFormat
    {

        public DBObject DB { get; set; }
        public string Table { get; set; }

        public object InsertSql()
        {
            return HelperMethods.GenerateSqlInsert(DataObjects, Table);
        }

        public override object ToDataFormat()
        {
            throw new NotImplementedException();
        }

        public override void WriteToFile(string directoryLocation, string fileName)
        {
            throw new NotImplementedException();
        }

        public void Connect(string Source, string Catalog, string UserName, string Password)
        {
            var connectObject = new DBConnectObject(Source, Catalog, UserName, Password);
            DB = new DBObject(connectObject);
        }

        public DBDataFormat(string Source, string Catalog, string UserName, string Password) : base()
        {
            Connect(Source, Catalog, UserName, Password);
        }

    }
}
