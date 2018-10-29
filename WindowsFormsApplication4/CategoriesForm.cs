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
    public struct categories
    {
        public string name;
        public Button del;
    }
    

    public partial class CategoriesForm : Form
    {

        public bool admin;
        public static List<categories> CategoriesList = new List<categories>();
        public string text;

        public CategoriesForm(bool ad)
        {
            admin = ad;
            InitializeComponent();

            update();            
        }

        public void update()
        {
            this.Controls.Clear();
            if (admin == true)
            {
                this.Controls.Add(button_add);
            }
            this.Controls.Add(textBox_name);
            CategoriesList.Clear();

            MySqlCommand cmd = new MySqlCommand(
                "SELECT Name FROM Categories ORDER BY Name", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                Label label = new Label();
                label.Size = new Size(100, 30);
                label.Location = new Point(20, 10 + 30 * i);
                label.Text = rdr[0].ToString();
                categories newcat = new categories();
                newcat.name = label.Text;

                if (admin == true)
                {
                    Button button_delete = new Button();
                    button_delete.Size = new Size(100, 30);
                    button_delete.Location = new Point(190, 10 + 30 * i);
                    button_delete.Text = "Удалить";
                    newcat.del = button_delete;
                    newcat.del.Click += new System.EventHandler(button_delete_Click);

                    this.Controls.Add(button_delete);
                    CategoriesList.Add(newcat);
                }
               
                this.Controls.Add(label);
                i++;
            }
            rdr.Close();                
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            foreach (categories cat in CategoriesList)
            {
                if (sender.Equals(cat.del))
                {
                    MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM `Categories` WHERE `Name`= '" + cat.name + "'", SQLClass.CONN);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Close();
                }
            }   

            update();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_name.Visible = true;
            
        }

        private void textBox_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MySqlCommand cmd = new MySqlCommand(
                 "INSERT INTO `Categories`(`Name`, `Picture`, `Coteg_ID`) VALUES (\"" + textBox_name.Text + "\", \"a\", 0)", SQLClass.CONN);

                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                update();
            }
        }
    }
}
