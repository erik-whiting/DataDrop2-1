using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrop2.Models
{
    class DBObject
    {
        private DBConnectObject ConnectionObject { get; set; }
        private SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public string Status { get; set; }


        public DBObject(DBConnectObject conn)
        {
            ConnectionObject = conn;
            Connection = new SqlConnection(ConnectionObject.MakeConnectionString());
            try
            {
                Connection.Open();
                Status = "Connected";
            }
            catch (Exception ex)
            {
                Status = "Connection Failed: " + ex;
            }
        }

        public void CloseConnection()
        {
            Connection.Close();
            Status = "Disconnected";
        }

        public SqlDataReader Query(string SQL)
        {
            Command = new SqlCommand(SQL, Connection);
            return Command.ExecuteReader();
        }
    }
}
