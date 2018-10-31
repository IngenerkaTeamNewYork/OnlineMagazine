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
    public partial class AuthorMainForm : Form
    {
        public string login;
        public AuthorMainForm(string log)
        {
            login = log;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(
                "SELECT `Information_about_author`, Articles, Pic FROM `Authors` WHERE `UserName` = '" + login + "'", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                aboutAuthorLabel.Text = rdr[0].ToString();
                label5.Text = rdr[1].ToString();
                        
                if (rdr[0].ToString() != "")
                {
                    
                    String str = rdr[2].ToString();
                    Avatar_author.LoadAsync(rdr[2].ToString());
                    Avatar_author.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    Avatar_author.Image = null;

                }
            }
            rdr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Statia f1 = new Add_Statia(login);
            f1.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CategoriesForm f = new CategoriesForm(false);
            f.ShowDialog();
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            Balance_Author OknoBalance = new Balance_Author();
            OknoBalance.ShowDialog();
        }

        private void panel_spisok_statey_Paint(object sender, PaintEventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(
               "SELECT `Header` FROM `Articles1` WHERE `Author` = '" + login + "'", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                Label label = new Label();
                label.Size = new Size(100, 30);
                label.Location = new Point(12, 50 + 50 * i);
                label.Text = rdr[0].ToString();
                this.panel_spisok_statey.Controls.Add(label);
                i++;
            }

            rdr.Close();
        }
    }
}
