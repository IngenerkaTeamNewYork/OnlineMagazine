using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net;

namespace WindowsFormsApplication4
{
    public partial class VipStatiy : Form
    {
        WebClient client = new WebClient();
        bool isLike = false;
        bool isDisLike = false;
        public string s;
        public VipStatiy(statiya stat)
        {
            InitializeComponent();

            name.Text = stat.name_statiya;
            kategoriy.Text = stat.kategorita_statii;
            s = stat.text_statii;
            label2.Text = stat.name_author;

        }

        public static void GetStata(Label lblLike, Label lblDisLike, String text)
        {
            List<String> likes = SQLClass.Select("SELECT LikesCount, DisCount FROM " + Tables.LIKES +
                " WHERE Article = '" + text + "'");

            if (likes.Count > 1)
            {
                lblLike.Text = likes[0];
                lblDisLike.Text = likes[1];
            }
            else
            {
                lblLike.Text = "0";
                lblDisLike.Text = "0";
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isDisLike = !isDisLike;
            pictureBox2.Image = (isDisLike) ?
                Properties.Resources.DisLike2 :
                Properties.Resources.Dislike;

            List<String> dislikes = SQLClass.Select("SELECT Article FROM " + Tables.LIKES + " WHERE Article = '" + name.Text + "'");

            if (isDisLike)
            {
                if (dislikes.Count > 0)
                {
                    SQLClass.Update("UPDATE " + Tables.LIKES +
                        " SET DisCount = DisCount + 1" +
                        " WHERE Article = '" + name.Text + "'");
                }
                else
                {
                    SQLClass.Insert(
                        "INSERT INTO " + Tables.LIKES +
                        "(Article, Author, Category, LikesCount, DisCount)" +
                        " VALUES (" +
                        "'" + name.Text + "'" +
                        ", '" + label2.Text + "'" +
                        ", '" + kategoriy.Text + "'" +
                        ",0" +
                        ",1)");
                }
            }
            else
            {
                SQLClass.Update("UPDATE " + Tables.LIKES +
                    " SET DisCount = DisCount - 1" +
                    " WHERE Article = '" + name.Text + "'");
            }

            GetStata(label3, label4, name.Text);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            isLike = !isLike;
            pictureBox1.Image = (isLike) ?
                Properties.Resources.Like2 :
                Properties.Resources.like;

            List<String> likes = SQLClass.Select("SELECT Article FROM " + Tables.LIKES + " WHERE Article = '" + name.Text + "'");
            if (isLike)
            {
                if (likes.Count > 0)
                {
                    SQLClass.Update("UPDATE " + Tables.LIKES +
                        " SET LikesCount = LikesCount + 1" +
                        " WHERE Article = '" + name.Text + "'");
                }
                else
                {
                    SQLClass.Insert(
                        "INSERT INTO " + Tables.LIKES +
                        "(Article, Author, Category, LikesCount, DisCount)" +
                        " VALUES (" +
                        "'" + name.Text + "'" +
                        ", '" + label2.Text + "'" +
                        ", '" + kategoriy.Text + "'" +
                        ",1" +
                        ",0)");
                }
            }
            else
            {
                SQLClass.Update("UPDATE " + Tables.LIKES +
                    " SET LikesCount = LikesCount - 1" +
                    " WHERE Article = '" + name.Text + "'");
            }

            GetStata(label3, label4, name.Text);
        }
        private void labelClick(object sender, EventArgs e)
        {
            Process.Start(((LinkLabel)sender).Text);
        }


            private void VipStatiy_Load(object sender, EventArgs e)
        {
            GetStata(label3, label4, name.Text);
            String[] d = s.Split('\n');
            for (int i = 0; i < d.Length; i++)
            {

                if (d[d.Length - 1 - i].Contains("http://") || d[d.Length - 1 - i].Contains("https://"))
                {
                    LinkLabel label1 = new LinkLabel();
                    label1.Location = new Point(0, 0);
                    label1.Size = new Size(180, 20);
                    label1.Text = d[d.Length - 1 - i];
                    label1.Click += new System.EventHandler(labelClick);
                    label1.Dock = DockStyle.Top;
                    panel1.Controls.Add(label1);

                    PictureBox artImage = new PictureBox();
                    artImage.Location = new Point(0, 25);
                    artImage.Size = new Size(panel1.Width, 150);
                    artImage.Dock = DockStyle.Top;
                    artImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    panel1.Controls.Add(artImage);

                    String[] chasti_stroki = d[d.Length - 1 - i].Split(new char[] { ' ', '/' });

                    try
                    {
                        artImage.Image = new Bitmap(chasti_stroki[chasti_stroki.Length - 1]);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            artImage.LoadAsync(d[d.Length - 1 - i]);
                            Uri uri = new Uri(d[d.Length - 1 - i]);
                            client.DownloadFileAsync(uri, chasti_stroki[chasti_stroki.Length - 1]);
                        }
                        catch (Exception)
                        {
                            artImage.Dispose();
                        }
                    }
                }
                else
                {
                    Label label1 = new Label();
                    label1.Location = new Point(0, 0);
                    label1.Size = new Size(180, 20);
                    label1.Text = d[d.Length - 1 - i];
                    label1.Dock = DockStyle.Top;
                    panel1.Controls.Add(label1);
                }

            }
            List<String> countRecords = SQLClass.Select(
            "SELECT COUNT(*) FROM " + Tables.READ_OF_ARTICLES +
            " WHERE `name_of_article` = '" + name.Text + "'");
            label1.Text = "Просмотров: " + countRecords[0];
        }
    }
}
