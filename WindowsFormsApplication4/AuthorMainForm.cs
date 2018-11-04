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
    public partial class AuthorMainForm : Form
    {
        public string login;
        public AuthorMainForm(string log)
        {
            login = log;
            InitializeComponent();
        }
        public List<LinkLabel> arts = new List<LinkLabel>();
        private void ArticleClick(object sender, EventArgs e)
        {
            foreach (LinkLabel lab in arts)
            {
                if (sender.Equals(lab))
                {
                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT Header, Author, Category, Text, Picture FROM " + Tables.ARTICLES +
                        " WHERE header = '" + lab.Text + "'", SQLClass.CONN);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        statiya stat = new statiya();
                        stat.name_statiya = rdr[0].ToString();
                        stat.name_author = rdr[1].ToString();
                        stat.kategorita_statii = rdr[2].ToString();
                        stat.text_statii = rdr[3].ToString();
                        if (rdr[4].ToString() != "")
                        {
                            stat.picture = rdr[4].ToString();
                        }
                        else
                        {
                            stat.picture = null;
                        }

                        StatiyaForm OknoStatiya = new StatiyaForm(stat);
                        OknoStatiya.ShowDialog();
                    }
                    rdr.Close();
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(
                "SELECT `Information_about_author`, Articles, Pic FROM `Authors` WHERE `UserName` = '" + login + "'", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                aboutAuthorLabel.Text = rdr[0].ToString();
                //label5.Text = rdr[1].ToString();

                try
                {
                    Avatar_author.LoadAsync(rdr[2].ToString());
                }
                catch(Exception)
                {
                    Avatar_author.Image = new Bitmap("defolt_avtor.jpg");
                }
                Avatar_author.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            rdr.Close();

            MySqlCommand cm = new MySqlCommand("SELECT Header, Picture FROM " + Tables.ARTICLES + " WHERE `Author` = '" + login + "'", SQLClass.CONN);
            rdr = cm.ExecuteReader();

            int articleY = 50;
            while (rdr.Read())
            {
                LinkLabel label1 = new LinkLabel();
                label1.Location = new Point(0, articleY);
                label1.Size = new Size(panel1.Width, 20);
                label1.Text = rdr[0].ToString();
                label1.Click += new System.EventHandler(ArticleClick);
                panel1.Controls.Add(label1);

                {
                    PictureBox image1 = new PictureBox();
                    image1.Location = new Point(0, articleY + 25);
                    image1.Size = new Size(panel1.Width, 150);
                    image1.Image = new Bitmap("defolt_statiy.jpg");
                    image1.SizeMode = PictureBoxSizeMode.StretchImage;
                    try
                    {
                        image1.LoadAsync(rdr[1].ToString());
                    }
                    catch (Exception)
                    {
                    }
                    //  image1.LoadAsync(rdr[1].ToString());

                    panel1.Controls.Add(image1);
                }

                arts.Add(label1);
                articleY += 180;
            }
            rdr.Close();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.LoadAsync(Advertising.GetRandom());

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.LoadAsync(Advertising.GetRandom());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Statia f1 = new Add_Statia(login);
            f1.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CategoriesForm f = new CategoriesForm(false);
            f.ShowDialog();
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            Balance_Author OknoBalance = new Balance_Author();
            OknoBalance.ShowDialog();
        }

    /*    private void panel_spisok_statey_Paint(object sender, PaintEventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(
               "SELECT `Header` FROM `Articles1` WHERE `Author` = '" + login + "'", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                Label label = new Label();
                label.Size = new Size(100, 30);
                label.Location = new Point(12, 50 + 50 * i);
                label.Text = rdr[0].ToString();
                this.panel_spisok_statey.Controls.Add(label);
                i++;
            }

            rdr.Close();
        }*/
    }
}
