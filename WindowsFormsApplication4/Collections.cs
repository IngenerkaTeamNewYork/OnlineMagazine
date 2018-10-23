using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class Collections : Form
    {
        public Collections()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Collections_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT Header FROM " + Tables.ARTICLES, SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                checkedListBox1.Items.Add(rdr[0].ToString());
            }

            rdr.Close();
        }
    }
}
