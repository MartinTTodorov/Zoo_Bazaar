using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ConnectionDB
    {
        private MySqlConnection conn;


        public ConnectionDB()
        {
            string connInfo = "Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915";
            conn = new MySqlConnection(connInfo);
        }

        public MySqlConnection GetConnection()
        {
            return conn;
        }
    }
}
