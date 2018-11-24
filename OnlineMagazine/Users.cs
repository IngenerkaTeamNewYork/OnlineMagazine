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

        public static string CURRENT_USER = "NONAME";
        public static string CURRENT_USERPASS;

        public List<users> list_of_users = new List<users>();

        public Users()
        {
            InitializeComponent();
            name.Font = Configs.ZAGOLOVOK_FONT;
            label_feel.Font = Configs.ZAGOLOVOK_FONT;
            labelb.Font = Configs.ZAGOLOVOK_FONT;
        }

        private void Click(object sender, EventArgs e)
        {
            foreach (users i in list_of_users)
            {
                if (sender.Equals(i.btn))
                {
                    SQLClass.Update("UPDATE " + Tables.POLZOVATELI +
                        " SET ban = 1 WHERE login = '" + i.login + "'");
                }
            }

            Users_Load(null, null);
        }

        /// <summary>
        /// Разблокировка пользователя
        /// </summary>
        private void ras_Click(object sender, EventArgs e)
        {
            foreach (users i in list_of_users)
            {
                if (sender.Equals(i.ras))
                {
                    SQLClass.Update("UPDATE " + Tables.POLZOVATELI +
                        " SET ban = 0 WHERE login = '" + i.login + "'");
                }
            }

            Users_Load(null, null);
        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;

            list_of_users.Clear();
            panel1.Controls.Clear();
            List<String> UsersData = SQLClass.Select("SELECT Login, ban FROM " + Tables.POLZOVATELI);

            int CurrentY = 20;

            for (int userIndex = 0; userIndex < UsersData.Count; userIndex += 2)
            {
                LinkLabel linklabel1 = new LinkLabel();
                linklabel1.Size = new Size(70, 20);
                linklabel1.Location = new Point(10, CurrentY);
                linklabel1.Text = UsersData[userIndex].ToString();

                panel1.Controls.Add(linklabel1);

                Label label2 = new Label();
                label2.Size = new Size(70, 20);
                label2.Location = new Point(100, CurrentY);
                label2.Text = UsersData[userIndex + 1].ToString();
                panel1.Controls.Add(label2);

                Button button_ban = new Button();
                button_ban.Size = new Size(70, 20);
                button_ban.Location = new Point(190, CurrentY);
                button_ban.Text = "Забанить";


                Button button_ras = new Button();
                button_ras.Size = new Size(70, 20);
                button_ras.Location = new Point(260, CurrentY);
                button_ras.Text = "Разблочить";

                users newUser = new users();
                newUser.login = linklabel1.Text;
                newUser.ban = Boolean.Parse(label2.Text); 

                newUser.btn = button_ban;
                newUser.btn.Click += new System.EventHandler(Click);
                panel1.Controls.Add(newUser.btn);

                newUser.ras = button_ras;
                newUser.ras.Click += new System.EventHandler(ras_Click);
                panel1.Controls.Add(newUser.ras);

                list_of_users.Add(newUser);
                CurrentY += 20;
            }
        }

        private void button_Click ()
        {
            //MySqlCommand cmd = new MySqlCommand("SELECT Login FROM `Polzovateli` ", SQLClass.CONN);
        }

        
     }
    
}
