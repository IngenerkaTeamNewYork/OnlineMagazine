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
    public partial class Users : Form
    {

        public List<users> list_of_users = new List<users>();

        public Users()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            foreach (users i in list_of_users)
            {
                if (sender.Equals(i.btn))
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Polzovateli SET ban = 1 WHERE login = '" + i.login + "'", SQLClass.CONN);
                    MessageBox.Show(cmd.CommandText);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("SELECT Login FROM `Polzovateli` ", SQLClass.CONN);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();


            int uy = 0;

            while (rdr1.Read())
            {
                LinkLabel linklabel1 = new LinkLabel();
                linklabel1.Size = new Size(70, 20);
                linklabel1.Location = new Point(10, 20 + 20 * uy);
                linklabel1.Text = rdr1[0].ToString();

                panel1.Controls.Add(linklabel1);

                Button button_ban = new Button();
                button_ban.Size = new Size(70, 20);
                button_ban.Location = new Point(100, 20 + 20 * uy);
                button_ban.Text = "Забанить";


              /*  Button button_ras = new Button();
                button_ras.Size = new Size(70, 20);
                button_ras.Location = new Point(300, 5 + 10 * uy);
                button_ras.Text = "Разблочить";*/

                //panel1.Controls.Add(button_ras);
                users newUser = new users();
                newUser.login = linklabel1.Text;

                newUser.btn = button_ban;
                newUser.btn.Click += new System.EventHandler(Click);
                panel1.Controls.Add(newUser.btn);

                list_of_users.Add(newUser);
                uy++;
            }
            rdr1.Close();

        }

        private void button_Click ()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT Login FROM `Polzovateli` ", SQLClass.CONN);
        }
     }
    
}
