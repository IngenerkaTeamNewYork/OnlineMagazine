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
        public string categoria;

        public CategoriesForm(bool ad)
        {
            admin = ad;
            InitializeComponent();

            update();            
        }

        public void update()
        {
            articlesPanel.Controls.Clear();
            catsPanel.Controls.Clear();
            if (admin == true)
            {
                catsPanel.Controls.Add(button_add);
            }
            catsPanel.Controls.Add(textBox_name);
            CategoriesList.Clear();

            MySqlCommand cmd = new MySqlCommand(
                "SELECT Name FROM Categories ORDER BY Name", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                Label label = new Label();
                label.Size = new Size(100, 30);
                label.Location = new Point(20, 50 + 30 * i);
                label.Text = rdr[0].ToString();
                categories newcat = new categories();
                newcat.name = label.Text;
                categoria = label.Text;
                label.Click += new System.EventHandler(lable_cat_Click);


                if (admin == true)
                {
                    Button button_delete = new Button();
                    button_delete.Size = new Size(100, 30);
                    button_delete.Location = new Point(190, 50 + 30 * i);
                    button_delete.Text = "Удалить";
                    newcat.del = button_delete;
                    newcat.del.Click += new System.EventHandler(button_delete_Click);

                    this.Controls.Add(button_delete);
                    CategoriesList.Add(newcat);
                }


                this.catsPanel.Controls.Add(label2);
                catsPanel.Controls.Add(label);
                i++;
            }
            rdr.Close();                
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            foreach (categories cat in CategoriesList)
            {
                if (sender.Equals(cat.del))
                {
                    SQLClass.Delete("DELETE FROM " + Tables.CATEGORIES +
                        " WHERE `Name`= '" + cat.name + "'");                    
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
                SQLClass.Insert("INSERT INTO " + Tables.CATEGORIES +
                    "(`Name`, `Picture`, `Coteg_ID`)" +
                    " VALUES (\"" + textBox_name.Text + "\", \"a\", 0)");

                update();
            }
        }

        private void lable_cat_Click (object sender, EventArgs e)
        {
            list_of_stat.GetListOfArtic(ref articlesPanel, ((Label)sender).Text);
            this.articlesPanel.Controls.Add(label3);
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            statiya stat = statiya.Click1(((Label)sender).Text);

            pictureBox1.Visible = true;
            pictureBox1.Load(stat.picture);
            pictureBox1.Size = new Size(100, 100); 
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
