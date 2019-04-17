using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    /// <summary>
    /// UserControl авторизации
    /// </summary>
    public partial class AuthenticationUserControl : UserControl
    {
        public DragAndDrop Drag = new DragAndDrop();
        public List<string> asd;
        public AuthenticationUserControl(List<string> parametrs)
        {
            InitializeComponent();
            Drag.AddDNDFunctions(this);
            Menus.AddDeleteMenu(this);
        }

        /// <summary>
        /// Добавление UserControl с аутентификацией
        /// </summary>
        public static void AddNewBlock(object sender, EventArgs e)
        {
            Control c = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            UCParameters p = new UCParameters("block.AuthenticationUserControl", new List<string>());
            p.ShowDialog();
            AuthenticationUserControl a1 = new AuthenticationUserControl(p.ParamsList);
            a1.Location = p.UCLocation;
            string shsvfhksv = "";
            foreach (string asd in p.ParamsList)
            {
                shsvfhksv += asd + ',';
            }
            Menus.InsertBlockToDB(sender, a1, shsvfhksv);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Dictionary<String, String> dict = new Dictionary<string, string>();
            dict.Add("STR", loginTextBox.Text);
            dict.Add("PASS", passwordTextBox.Text);
            //Users.CURRENT_USER = loginTextBox.Text;

            List<String> AuthorLoginData = SQLClass.Select
                ("SELECT COUNT(*) FROM " + Tables.AUTHORS +
                " WHERE UserName = @STR " +
                " AND UserName IN (SELECT Login FROM " + Tables.POLZOVATELI +
                " WHERE Login = @STR and Parol = @PASS)", dict);

            List<String> Polzovatel = SQLClass.Select
                ("SELECT COUNT(*) FROM " + Tables.POLZOVATELI +
                " WHERE Login = @STR and Parol = @PASS", dict);

            GhostMainForm.aut = (AuthorLoginData[0] != "0");
            GhostMainForm.adm = (loginTextBox.Text != "" && To_come_in.LogIntoAdminZone(loginTextBox.Text, passwordTextBox.Text));
            Users.CURRENT_USER = "NONAME";
            if (!GhostMainForm.aut && !GhostMainForm.adm && Polzovatel[0] == "0")
            {
                MessageBox.Show("Вас в безе нет (Не верен пароль или логин)");
            }
            else
            {
                Users.CURRENT_USER = loginTextBox.Text;
                MessageBox.Show("1234");
                //Users.CURRENT_USER = textBox_login.Text;
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void AuthenticationUserControl_Load(object sender, EventArgs e)
        {
            //if (Program.ShowColor == true)
            //{
            //    this.BackColor = SystemColors.ActiveBorder;

            //}
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
