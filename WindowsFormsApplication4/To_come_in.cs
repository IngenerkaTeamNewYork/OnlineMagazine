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

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM `Polzovateli` WHERE `Login`=\"" + textBox_login.Text + "\" AND `admin` = 1", SQLClass.CONN);
                MySqlDataReader rdr1 = cmd1.ExecuteReader();

                rdr1.Read();
                String IsAdmin = rdr1[0].ToString();
                rdr1.Close();
                
                if (IsAdmin == "0")//!checkBox_admin.Checked)
                {
                    //Form ifr = Application.OpenForms[0];
                    //ifr.Show();
                    // GhostMainForm link_of_come.Visible = false;
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM Polzovateli WHERE `Login`=\"" + textBox_login.Text + "\" AND `Parol`=\"" + textBox_password.Text + "\"", SQLClass.CONN);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                        
                    bool isloginok = false;
                    while (rdr.Read())
                    {
                        isloginok = true;
                    }
                    rdr.Close();
                    if (isloginok)
                    {
                        Form ifrm = new AdminMainForm();
                        ifrm.Show(); // отображаем Form2
                        ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                        ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                        this.Close();// скрываем Form1 (this - текущая форма)
                        Form prichem = Application.OpenForms[0];
                        prichem.Hide();
                    }
                    else
                    {
                        MessageBox.Show("password");
                    }
                    rdr.Close();
                }
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
