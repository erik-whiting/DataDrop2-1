using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2.Models
{
    class DBConnectObject
    {
        private string Source { get; set; }
        private string Catalog { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }

        public DBConnectObject(string Source, string Catalog, string UserName, string Password)
        {

        }

        public string MakeConnectionString()
        {
            return @"Data Source={Source};Initial Catalog={Catalog};User Id={UserName};Password={Password}";
        }

    }
}
