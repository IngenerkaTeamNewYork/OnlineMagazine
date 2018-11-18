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

        private void Registration_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Добавляем пользователя
            List<String> byl = SQLClass.Select(
                "SELECT COUNT(*) FROM " + Tables.POLZOVATELI + " WHERE Login='" + textBox_login.Text + "'");
            bool userBylUzhe = (byl[0].ToString() != "0");

            if (userBylUzhe)
            {
                MessageBox.Show("Ты был уже. Регистрируйся заново");
                return;
            }

            SQLClass.Insert("INSERT INTO " + Tables.POLZOVATELI +
                "(`Login`, `Parol`, `ban`, `aboutme`, admin, zapas)" +
                " VALUES ('" + textBox_login.Text + "'," +
                "'" + textBox_password.Text + "'," +
                "0" + ",'" + textBox_about_me.Text + "', 0)");
            #endregion


            if (checkBox_I_author.Checked == true)
            {
                #region Добавляем автора
                List<String> isAdminData = SQLClass.Select(
                    "SELECT COUNT(*) FROM " + Tables.AUTHORS + " WHERE `UserName`=\"" + textBox_login.Text +
                    "\"");
                bool BylUzhe = (isAdminData[0].ToString() != "0");

                if (BylUzhe)
                {
                    MessageBox.Show("Ты был уже. Регистрируйся заново");
                    return;
                }

                SQLClass.Insert("INSERT INTO " + Tables.AUTHORS + 
                    "(UserName, Information_about_author, Pic) " +
                    "VALUES ('" + textBox_login.Text + "','" + 
                    textBox_about_me.Text + "', '" +
                    textBox_pic + "')");
                #endregion
            }

            Close();            
        }

        private void textBox_about_me_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || checkBox_agree.Checked)
            {
                button1_Click(sender, null);
            }
        }

        private void checkBox_agree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || checkBox_agree.Checked)
            {
                button1_Click(sender, null);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Load(textBox_pic.Text); 

            }
            catch(Exception)
            {
                pictureBox1.Load("https://memepedia.ru/wp-content/uploads/2017/04/%D0%B5%D0%B1%D0%B0%D1%82%D1%8C-%D1%82%D1%8B-%D0%BB%D0%BE%D1%85-%D0%BE%D1%80%D0%B8%D0%B3%D0%B8%D0%BD%D0%B0%D0%BB.jpg");
               
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
