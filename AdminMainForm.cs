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
    public struct Reklama
    {
        public DateTime dateFrom; 
        public string text;
        public Boolean n;
    }

    public partial class AdminMainForm : Form
    {
        public List<Reklama> mnogo_reklamy = new List<Reklama>();

        public AdminMainForm()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT Text, data_to, new FROM Advertisment", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Reklama rek = new Reklama();
                rek.text = rdr[0].ToString();
                rek.dateFrom = Convert.ToDateTime(rdr[1].ToString());
                rek.n = Convert.ToBoolean(rdr[2].ToString());
                mnogo_reklamy.Add(rek);
            }
            rdr.Close();

            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Spisok_reklamy sps = new Spisok_reklamy(mnogo_reklamy);
            sps.ShowDialog();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            //Spisok_reklamy d = new Spisok_reklamy("gryzha");
            //d.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form ifr = Application.OpenForms[0];
            ifr.Left = this.Left;
            ifr.Top = this.Top;
            ifr.Show();
            this.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            New_stati fgf = new New_stati();
            fgf.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CategoriesForm form = new CategoriesForm();
            form.ShowDialog();
        }

        private void button_author_Click(object sender, EventArgs e)
        {
            FBIform form = new FBIform();
            form.ShowDialog();
        }

        private void button_statistika_Click(object sender, EventArgs e)
        {
            StastisticsForm form1 = new StastisticsForm(/*GhostMainForm.stat[0]*/);
            form1.ShowDialog();
        }

        private void button_all_users_Click(object sender, EventArgs e)
        {
            String connString = "SslMode=none;" +
                "Server=db4free.net;" +
                "database=ingenerka;port=3306;uid=ingenerka;pwd=Beavis1989;old guids=true;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT Login, Parol FROM `Polzovateli`", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                MessageBox.Show("Login = " + rdr[0].ToString() +
                    " Parol = " + rdr[1].ToString() );
            }
            rdr.Close();


            conn.Close();
        }
        private void button_categories_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_return_Click(object sender, EventArgs e)
        {
            AdminMainForm_FormClosed(null, null);
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Form ifr = Application.OpenForms[0];
            ifr.Left = this.Left;
            ifr.Top = this.Top;
            ifr.Show();
        }

        private void button_statistika_Click_1(object sender, EventArgs e)
        {
            StastisticsForm t = new StastisticsForm();
            t.ShowDialog();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Collections c = new Collections();
            c.ShowDialog();
        }
    }
}
