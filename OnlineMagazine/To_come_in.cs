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

        /// <summary>
        /// Вход в систему под админом
        /// </summary>
        public static bool LogIntoAdminZone(String Login, String Password)
        {
            //Проверка на администратора
            List<String> isAdminData = SQLClass.Select(
                "SELECT COUNT(*) FROM " + Tables.POLZOVATELI + " WHERE `Login`=\"" + Login + 
                "\" AND `admin` = 1");
            String IsAdmin = isAdminData[0].ToString();


            if (IsAdmin != "0")
            {
                List<String> loginSuccessData = SQLClass.Select(
                    "SELECT * FROM " + Tables.POLZOVATELI + 
                    " WHERE `Login`=\"" + Login + "\" AND `Parol`=\"" + Password + "\"");

                if (loginSuccessData.Count > 0)
                {
                    Form ifrm = new AdminMainForm();
                    ifrm.ShowDialog();
                    return true;
                }

                else
                {
                    MessageBox.Show("password");
                }
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIntoAdminZone(textBox_login.Text, textBox_password.Text);
            
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, null);
            }
        }

        private void To_come_in_Load(object sender, EventArgs e)
        {

        }
    }
}