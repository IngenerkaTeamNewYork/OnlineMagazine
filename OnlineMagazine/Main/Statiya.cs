using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;


using MySql.Data;
using MySql.Data.MySqlClient;

namespace OnlineMag
{
    public struct statiya
    {
        public String name_statiya;
        public String name_author;
        public Image kartinki_statii;
        public String kategorita_statii;
        public String text_statii;
        public String picture;

        public void ShowText()
        {
            MessageBox.Show("1");
        }

        public static statiya Click1 (String Text)
        {        
            MySqlCommand cmd = new MySqlCommand("SELECT Header, Author, Category, Text, Picture FROM " + Tables.ARTICLES + " WHERE `Header` = '" + Text + "'", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();            
            statiya stat = new statiya();
            stat.name_statiya = rdr[0].ToString();
            stat.name_author = rdr[1].ToString();
            stat.kategorita_statii = rdr[2].ToString();
            stat.text_statii = rdr[3].ToString();
            if (rdr[4].ToString() != "")
            {
                stat.picture = rdr[4].ToString();
            }
            else
            {
                stat.picture = null;
            }
            rdr.Close();

            return stat;
        }

    }
}
