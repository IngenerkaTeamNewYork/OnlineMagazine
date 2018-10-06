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
    public partial class CategoriesForm : Form
    {
        public static List<String> CategoriesList = new List<string>(new string[] { });
        public string text;

        public CategoriesForm()
        {
            InitializeComponent();
            int ind = 0;
            foreach (String cat in CategoriesList)
            {
                for (int i = 0; i > 0; i++)
                {
                    Label label = new Label();
                    label.Size = new Size(70, 80);
                    label.Location = new Point(50, 10 + 30 * ind);
                    label.Text = CategoriesList[i];
                    this.Controls.Add(label);
                }
            }
            update();
        }

        public void update()
        {
            CategoriesList.Clear();

            MySqlCommand cmd = new MySqlCommand(
                "SELECT Name FROM Categories", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                CategoriesList.Add(rdr[0].ToString());
            }
            rdr.Close();


            textBox_name.Text = "";
            foreach (String a in CategoriesList)
            {
                textBox_name.Text += a;
            }
            
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM `Categories` WHERE `Name`= '" + textBox_name.Text + "'", SQLClass.CONN);
            cmd.ExecuteReader();

            update();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO `Categories`(`Name`, `Picture`, `Coteg_ID`) VALUES (\"" + textBox_name.Text + "\", \"a\", 1)", SQLClass.CONN);
            cmd.ExecuteReader();
            update();
        }
    }
}
