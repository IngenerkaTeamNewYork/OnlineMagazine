using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public static class SQLClass
    {
        public static string CONNECTION_STRING =
            "SslMode=none;" +
            "Server=db4free.net;" +
            "database=ingenerka;" +
            "port=3306;" +
            "uid=ingenerka;" +
            "pwd=Beavis1989;" +
            "old guids=true;";

        public static MySqlConnection CONN;

        public static void OpenConnection()
        {
            CONN = new MySqlConnection(CONNECTION_STRING);
            CONN.Open();
        }

        public static void CloseConnection()
        {
            CONN.Close(); ;
        }
    }
}