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
    public partial class list_of_stat : Form
    {
        public static void GetListOfArtic(ref Panel comp, string cat)
        {
            comp.Controls.Clear();
            List<String> ArticlesList = SQLClass.Select("SELECT `Header` FROM " + Tables.ARTICLES + 
                " WHERE `Category` = '" + cat + "'");

            int artY = 10;
            foreach(String Article in ArticlesList)
            {
                Label label1 = new Label();
                label1.Size = new Size(200, 20);
                label1.Location = new Point(50, artY);
                label1.Text = Article;
                label1.Click += new System.EventHandler(lable1_Click);

                comp.Controls.Add(label1);
                artY += 30;
            }

            if (artY == 10)
            {
                Label label1 = new Label();
                label1.Size = new Size(200, 20);
                label1.Location = new Point(50, artY);
                label1.Text = "Тут ничего нет";
                comp.Controls.Add(label1);
            }
        }

        public list_of_stat(string cat)
        {
            InitializeComponent();
        }

        private void list_of_stat_Load(object sender, EventArgs e)
        {

        }

        private static void lable1_Click (object sender, EventArgs e)
        {
            statiya stat = statiya.Click1(((Label)sender).Text);

            StatiyaForm form = new StatiyaForm(stat);
            form.ShowDialog();
        }
    }
}
