using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Reflection;

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
            CONN.Close();
        }

        public static void insert(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
        }
        public static void update(string cmdText)
        {
            insert(cmdText);
        }
        public List<T> Query<T>(string query) where T : new()
        {
            List<T> res = new List<T>();
            MySqlCommand q = new MySqlCommand(query, CONN);
            MySqlDataReader r = q.ExecuteReader();
            while (r.Read())
            {
                T t = new T();

                for (int inc = 0; inc < r.FieldCount; inc++)
                {
                    Type type = t.GetType();
                    PropertyInfo prop = type.GetProperty(r.GetName(inc));
                    prop.SetValue(t, Convert.ChangeType(r.GetValue(inc), prop.PropertyType), null);
                }

                res.Add(t);
            }
            r.Close();

            return res;
        }
    }
}