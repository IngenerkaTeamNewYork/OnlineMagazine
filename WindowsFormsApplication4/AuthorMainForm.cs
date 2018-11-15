
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Net;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class AuthorMainForm : Form
    {
        public string login;
        WebClient client = new WebClient();
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
                    List<String> ArticleInfo = SQLClass.Select(
                        "SELECT Header, Author, Category, Text, Picture FROM " + Tables.ARTICLES +
                        " WHERE header = '" + lab.Text + "'");

                    for (int artIndex = 0; artIndex < ArticleInfo.Count; artIndex += 5)
                    {
                        statiya stat = new statiya();
                        stat.name_statiya = ArticleInfo[artIndex].ToString();
                        stat.name_author = ArticleInfo[artIndex + 1].ToString();
                        stat.kategorita_statii = ArticleInfo[artIndex + 2].ToString();
                        stat.text_statii = ArticleInfo[artIndex + 3].ToString();

                        //FIXME!!! Show ternarny operator
                        stat.picture = (ArticleInfo[artIndex +4].ToString() != "") ?
                            ArticleInfo[artIndex + 4].ToString() :
                            null;

                        StatiyaForm OknoStatiya = new StatiyaForm(stat);
                        OknoStatiya.ShowDialog();
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<String> AuthorInfo = SQLClass.Select(
                "SELECT Information_about_author, Articles, Pic FROM " + Tables.AUTHORS +
                " WHERE `UserName` = '" + login + "'");

            for (int infoIndex = 0; infoIndex < AuthorInfo.Count; infoIndex += 3)
            {
                aboutAuthorLabel.Text = AuthorInfo[infoIndex].ToString();
                String[] chasti_stroki = AuthorInfo[infoIndex + 2].ToString().Split(new char[] { ' ', '/' });
                
                try
                {
                    Avatar_author.Image = new Bitmap(chasti_stroki[chasti_stroki.Length - 1]);
                }
                catch (Exception)
                {
                    try
                    {
                        Avatar_author.Load(AuthorInfo[infoIndex + 2].ToString());
                        Uri uri = new Uri(AuthorInfo[infoIndex + 2].ToString());
                        client.DownloadFileAsync(uri, chasti_stroki[chasti_stroki.Length - 1]);
                    }
                    catch (Exception)
                    {
                        Avatar_author.Image = new Bitmap("defolt_avtor.jpg");
                    }
                }
                
                Avatar_author.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            List<String> AuthorArticles = SQLClass.Select("SELECT Header, Picture FROM " + Tables.ARTICLES + 
                " WHERE `Author` = '" + login + "'");

            int articleY = 50;
            for (int artIndex = 0; artIndex < AuthorArticles.Count; artIndex += 2)
            {
                LinkLabel label1 = new LinkLabel();
                label1.Location = new Point(0, articleY);
                label1.Size = new Size(panel1.Width, 20);
                label1.Text = AuthorArticles[artIndex].ToString();
                label1.Dock = DockStyle.Top;
                label1.Click += new System.EventHandler(ArticleClick);
                panel1.Controls.Add(label1);
                
                PictureBox image1 = new PictureBox();
                image1.Location = new Point(0, articleY + 25);
                image1.Size = new Size(panel1.Width, 150);
                image1.Image = new Bitmap("defolt_statiy.jpg");
                image1.SizeMode = PictureBoxSizeMode.StretchImage;
                image1.Dock = DockStyle.Top;
                panel1.Controls.Add(image1);

                String[] chasti_stroki = AuthorArticles[artIndex + 1].ToString().Split(new char[] { ' ', '/' });

                try
                {
                    image1.Image = new Bitmap(chasti_stroki[chasti_stroki.Length - 1]);
                }
                catch (Exception)
                {
                    try
                    {
                        image1.Load(AuthorArticles[artIndex + 1].ToString());
                        Uri uri = new Uri(AuthorArticles[artIndex + 1].ToString());
                        client.DownloadFileAsync(uri, chasti_stroki[chasti_stroki.Length - 1]);
                    }
                    catch (Exception)
                    {
                    }
                }

                arts.Add(label1);
                articleY += 180;
            }

            //FIXME!!! Show region
            #region Advertising
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            List<string> s = Advertising.GetRandom();
            pictureBox1.LoadAsync(s[0]);
            pictureBox1.Tag = s[1];

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            s = Advertising.GetRandom();
            pictureBox2.LoadAsync(s[0]);
            pictureBox2.Tag = s[1];

            #endregion
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
    }
}