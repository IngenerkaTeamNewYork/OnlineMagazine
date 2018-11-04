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
    public partial class list_of_stat : Form
    {

        statiya stat = new statiya();

        public static void GetListOfArtic(ref Panel comp, string cat)
        {
            comp.Controls.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT `Header` FROM " + Tables.ARTICLES + " WHERE `Category` = '" + cat + "'", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            int i = 0;

            while (rdr.Read())
            {
                Label label1 = new Label();
                label1.Size = new Size(200, 20);
                label1.Location = new Point(50, 10 + 30 * i);
                label1.Text = rdr[0].ToString();
                label1.Click += new System.EventHandler(lable1_Click);

                comp.Controls.Add(label1);

                i++;
            }

            if (i == 0)
            {
                Label label1 = new Label();
                label1.Size = new Size(200, 20);
                label1.Location = new Point(50, 10 + 30 * i);
                label1.Text = "Тут ничего нет";
                comp.Controls.Add(label1);
            }
            rdr.Close();

        }

        public list_of_stat(string cat)
        {

            InitializeComponent();
            MySqlCommand cmd = new MySqlCommand("SELECT `Header` FROM `Articles1` WHERE `Category` = '" + cat + "'", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            int i = 0;
            
            while (rdr.Read())
            {
                    Label label1 = new Label();
                    label1.Size = new Size(200, 20);
                    label1.Location = new Point(50, 10 + 30 * i);
                    label1.Text = rdr[0].ToString();
                    label1.Click += new System.EventHandler(lable1_Click);

                    this.Controls.Add(label1);

                    i++;
            }

            if (i == 0)
            {
                Label label1 = new Label();
                label1.Size = new Size(200, 20);
                label1.Location = new Point(50, 10 + 30 * i);
                label1.Text = "Тут ничего нет";
                this.Controls.Add(label1);
            }

            rdr.Close();
        }

        private void list_of_stat_Load(object sender, EventArgs e)
        {

        }

        private static void lable1_Click (object sender, EventArgs e)
        {
            statiya stat = statiya.Click1(((Label)sender).Text);

            StatiyaForm1 form = new StatiyaForm1(stat);
            form.ShowDialog();
        }
    }
}
