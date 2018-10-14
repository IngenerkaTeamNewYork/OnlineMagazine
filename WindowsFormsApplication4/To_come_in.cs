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


using System.Diagnostics;
using System.IO;


namespace WindowsFormsApplication4
{
    public partial class To_come_in : Form
    {
        public To_come_in()
        {
            InitializeComponent();
        }

        public static void LogIntoAdminZone(String Login, String Password)
        {
            //Проверка на администратора
            MySqlCommand cmd1 = new MySqlCommand(
                "SELECT COUNT(*) FROM `Polzovateli` WHERE `Login`=\"" + Login + 
                "\" AND `admin` = 1", SQLClass.CONN);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();

            rdr1.Read();
            String IsAdmin = rdr1[0].ToString();
            rdr1.Close();

            if (IsAdmin != "0")
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM Polzovateli WHERE `Login`=\"" + Login + "\" AND `Parol`=\"" + Password + "\"", SQLClass.CONN);
                MySqlDataReader rdr = cmd.ExecuteReader();

                bool isloginok = rdr.Read();
                rdr.Close();

                if (isloginok)
                {
                    Form ifrm = new AdminMainForm();
                    ifrm.ShowDialog();
                    Form prichem = Application.OpenForms[0];
                    prichem.Hide();
                }
                else
                {
                    MessageBox.Show("password");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIntoAdminZone(textBox_login.Text, textBox_password.Text);
        }

        private void To_come_in_Load(object sender, EventArgs e)
        {

        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, null);
            }
        }
    }
}