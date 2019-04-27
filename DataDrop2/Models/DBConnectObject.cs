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

        public DBConnectObject(string source, string catalog, string userName, string password)
        {
            Source = source;
            Catalog = catalog;
            UserName = userName;
            Password = password;
        }

        public string MakeConnectionString()
        {
            var connString = "Data Source=" + Source + ";";
            connString += "Initial Catalog=" + Catalog + ";";
            connString += "User ID=" + UserName + ";";
            connString += "Password=" + Password;
            return connString;
        }

    }
}
