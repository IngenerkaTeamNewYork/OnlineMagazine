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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Добавить_картинку AddPromoForm = new Добавить_картинку();
            AddPromoForm.ShowDialog();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO `Polzovateli`(`Login`, `Parol`, `ban`, `aboutme`) VALUES (\"" + textBox_login.Text +  "\",\"" + textBox_password.Text + "\",\"" + "0" +  "\",\"" + textBox_about_me.Text + "\")", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            Close();
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_about_me_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_about_me_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || checkBox_agree.Checked)
            {
                button1_Click(sender, null);
            }
        }
    }
}
