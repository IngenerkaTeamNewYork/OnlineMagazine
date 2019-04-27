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

namespace OnlineMag
{
    public partial class CategoryArticlesList : Form
    {
        public static PictureBox pictureBox1 = new PictureBox();

        public static void GetListOfArtic(ref Panel comp, string cat)
        {
            comp.Controls.Clear();
            comp.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(300, 10);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            List<String> ArticlesList = SQLClass.Select("SELECT `Header` FROM " + Tables.ARTICLES + 
                " WHERE `Category` = '" + cat + "'");

            int artY = 10;
            foreach(String Article in ArticlesList)
            {
                Label label1 = new Label();
                label1.Size = new Size(200, 20);
                label1.Location = new Point(50, artY+50);
                label1.Text = Article;
                label1.Click += new System.EventHandler(lable1_Click);
                label1.MouseEnter += new System.EventHandler(label1_MouseEnter);
                label1.MouseLeave += new System.EventHandler(label1_MouseLeave);

                comp.Controls.Add(label1);
                artY += 30;
            }

            if (artY == 10)
            {
                Label label1 = new Label();
                label1.Size = new Size(200, 20);
                label1.Location = new Point(50, artY+50);
                label1.Text = "Тут ничего нет";
                comp.Controls.Add(label1);
            }
        }

        public CategoryArticlesList(string cat)
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
        private static void label1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(((Label)sender).Location.X + 120, ((Label)sender).Location.Y);
            statiya stat = statiya.Click1(((Label)sender).Text);

            if (!String.IsNullOrEmpty(stat.picture) && stat.picture != null)
            {
                pictureBox1.Visible = true;
                pictureBox1.ImageLocation = stat.picture;
                pictureBox1.Load();
                pictureBox1.Size = new Size(90, 70);

            }

        }

        private static void label1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
