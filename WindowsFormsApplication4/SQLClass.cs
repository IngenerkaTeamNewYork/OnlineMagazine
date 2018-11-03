﻿using System;
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

        public static void Insert(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
        }

        /// <summary>
        /// Delete-запрос
        /// </summary>
        public static void Delete(string cmdText)
        {
            Insert(cmdText);
        }

        public static void Update(string cmdText)
        {
            Insert(cmdText);
        }

        /// <summary>
        /// Select-запрос
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <returns>Результат в виде списка строк</returns>
        public static List<String> Select(string query)
        {
            List<String> res = new List<String>();
            MySqlCommand q = new MySqlCommand(query, CONN);
            MySqlDataReader r = q.ExecuteReader();

            while (r.Read())
            {
                for (int inc = 0; inc < r.FieldCount; inc++)
                {
                    res.Add(r.GetString(inc));
                }
            }
            r.Close();

            return res;
        }
    }
}