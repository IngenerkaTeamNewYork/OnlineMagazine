using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Text;
using System.Net;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class GhostMainForm : Form
    {
        public static List<AuthorStat> stat = new List<AuthorStat>();

        public List<LinkLabel> arts = new List<LinkLabel>();
        public List<PictureBox> piccc = new List<PictureBox>();
        WebClient client = new WebClient();
        public string[] url = new string[50];
        int kolvo = 0;
        public string kuda_i_kak;

        
      
        public GhostMainForm()
        {
            InitializeComponent();
            //label_popular.Text = stat.kategorita_statii;
            SQLClass.OpenConnection();

            /*List<AuthorStat> writers = new List<AuthorStat>();
            int uy = 0;
            foreach (AuthorStat write in writers)
            {
                LinkLabel linklabel1 = new LinkLabel();
                linklabel1.Size = new Size (70, 20); 
                linklabel1.Location = new Point (50, 10 + 30*uy);
                linklabel1.Text = write.name;

                Left_panel.Controls.Add(linklabel1);
                uy++;
            }*/
        }

        private void ArticleClick(object sender, EventArgs e)
        {
            foreach (LinkLabel lab in arts)
            {
                if (sender.Equals(lab))
                {
                    statiya stat = statiya.Click1(((Label)sender).Text);
                    StatiyaForm OknoStatiya = new StatiyaForm(stat);
                    OknoStatiya.ShowDialog();
                }
            }
        }

        private void clik_na_pic(object sender, EventArgs e)
        {
            foreach (PictureBox lab in piccc)
            {
                if (sender.Equals(lab))
                {
                    statiya stat = statiya.Click1(lab.Tag.ToString());
                    StatiyaForm OknoStatiya = new StatiyaForm(stat);
                    OknoStatiya.ShowDialog();
                }
            }
        }  
      
        private void Form1_Load(object sender, EventArgs e)
        {


            List<String> artsList = SQLClass.Select("SELECT Name FROM " + Tables.CATEGORIES + " LIMIT 0, 7");

            int catY = 200;


            for (int artIndex = 0; artIndex < artsList.Count; artIndex ++)
            {
                Label label1 = new Label();
                label1.Location = new Point(0, catY);
                label1.Size = new Size(100, 20);
                label1.Text = artsList[artIndex].ToString();
                label1.Click += new System.EventHandler(label2_Click);
                Right_panel.Controls.Add(label1);
                catY += 30;
            }
            //arts.Add(label1);

            Centr_panel.Controls.Clear();
            Centr_panel.Controls.Add(popularArticlesLabel);

            textBox_login.Text = "";
            textBox_password.Text = "";

            #region Advertising
            reclama.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama.LoadAsync(Advertising.GetRandom());

            reclama2.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama2.LoadAsync(Advertising.GetRandom());
            
            reclama3.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama3.LoadAsync(Advertising.GetRandom());
            #endregion
            
            List<String> PopularArticles = SQLClass.Select(
                "SELECT Header, Picture FROM " + Tables.ARTICLES + 
                " WHERE new = 0 LIMIT 0, 7");

            int articleY = 50;
            for (int artIndex = 0; artIndex < PopularArticles.Count; artIndex += 2)
            {
                #region Article header
                Panel articleHeaderPanel = new Panel();
                articleHeaderPanel.Size = new Size(Centr_panel.Width, 30);
                articleHeaderPanel.Dock = DockStyle.Top;
                articleHeaderPanel.TabIndex = 0;
                Centr_panel.Controls.Add(articleHeaderPanel);

                LinkLabel label1 = new LinkLabel();
                label1.Location = new Point(0, 0);
                label1.Size = new Size(180, 20);
                label1.Text = PopularArticles[artIndex].ToString();
                label1.Click += new System.EventHandler(ArticleClick);
                articleHeaderPanel.Controls.Add(label1);

                PictureBox likesPB = new PictureBox();
                likesPB.Size = new Size(20, 20);
                likesPB.Location = new Point(200, 0);
                likesPB.Image = Properties.Resources.like;
                articleHeaderPanel.Controls.Add(likesPB);

                Label likesLabel = new Label();
                likesLabel.Location = new Point(230, 0);
                likesLabel.Size = new Size(20, 20);
                articleHeaderPanel.Controls.Add(likesLabel);

                Label dislikesLabel = new Label();
                dislikesLabel.Location = new Point(290, 0);
                dislikesLabel.Size = new Size(20, 20);
                articleHeaderPanel.Controls.Add(dislikesLabel);

                StatiyaForm.GetStata(likesLabel, dislikesLabel, label1.Text);
                #endregion

                //Video
                if (PopularArticles[artIndex + 1].ToString().Contains("www.youtube.com"))
                {
                    String url = PopularArticles[artIndex + 1].ToString().Replace("watch?v=", "embed/");

                    String embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"" + Centr_panel.Width + "\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";

                    WebBrowser web = new WebBrowser();
                    web.TabIndex = 1;
                    web.Dock = DockStyle.Top;
                    web.DocumentText = string.Format(embed, url);
                    web.Location = new Point(0, articleY + 25);
                    Centr_panel.Controls.Add(web);
                }
                //Picture
                else
                {
                    String[] chasti_stroki = PopularArticles[artIndex + 1].ToString().Split(new char[] { ' ', '/' });

                    PictureBox artImage = new PictureBox();
                    artImage.Location = new Point(0, articleY + 25);
                    artImage.Tag = label1.Text;
                    artImage.Size = new Size(Centr_panel.Width, 150);
                    artImage.Dock = DockStyle.Top;
                    artImage.Click += new System.EventHandler(clik_na_pic);
                    artImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    artImage.TabIndex = 1;

                    try
                    {
                        artImage.Image = new Bitmap(chasti_stroki[chasti_stroki.Length - 1]);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            artImage.LoadAsync(PopularArticles[artIndex + 1].ToString());
                            Uri uri = new Uri(PopularArticles[artIndex + 1].ToString());
                            client.DownloadFileAsync(uri, chasti_stroki[chasti_stroki.Length - 1]);
                        }
                        catch (Exception)
                        {
                            artImage.Image = new Bitmap("defolt_avtor.jpg");
                        }
                    }

                    Centr_panel.Controls.Add(artImage);                
                    piccc.Add(artImage);
                }                
                
                arts.Add(label1);
                articleY += 180;
            }
        }    


        private void butto_search_Click(object sender, EventArgs e)
        {
            Centr_panel.Controls.Clear();
            Centr_panel.Controls.Add(popularArticlesLabel);

            textBox_login.Text = "";
            textBox_password.Text = "";
            
            List<String> artsList = SQLClass.Select
                ("SELECT Header, Picture FROM " + Tables.ARTICLES +
                " WHERE header like '%" + textBox_search.Text + "%'" +
                " OR category like '%" + textBox_search.Text + "%'" +
                " OR author like '%" + textBox_search.Text + "%' LIMIT 0, 7");
            
            int articleY = 50;

            for (int artIndex = 0; artIndex < artsList.Count; artIndex += 2)
            {
                LinkLabel label1 = new LinkLabel();
                label1.Location = new Point(0, articleY);
                label1.Size = new Size(Centr_panel.Width, 20);
                label1.Text = artsList[artIndex].ToString();
                label1.Click += new System.EventHandler(ArticleClick);
                Centr_panel.Controls.Add(label1);


                
                PictureBox image1 = new PictureBox();
                image1.Location = new Point(0, articleY + 25);
                image1.Size = new Size(Centr_panel.Width, 150);
                image1.Click += new System.EventHandler(clik_na_pic);
                image1.SizeMode = PictureBoxSizeMode.StretchImage;

                String[] chasti_stroki = artsList[artIndex + 1].ToString().Split(new char[] { ' ', '/' });
                

                try
                {
                    image1.Image = new Bitmap(chasti_stroki[chasti_stroki.Length - 1]);
                }
                catch (Exception)
                {
                    try
                    {
                        Uri uri = new Uri(artsList[artIndex + 1].ToString());
                        image1.Load(artsList[artIndex + 1].ToString());
                        client.DownloadFileAsync(uri, chasti_stroki[chasti_stroki.Length - 1]);
                    }
                    catch (Exception)
                    {
                        image1.Image = new Bitmap("defolt_statiy.jpg");
                    }
                }
                    
                //image1.Click += new System.EventHandler(ArticleClick);
                Centr_panel.Controls.Add(image1);

                piccc.Add(image1);
                arts.Add(label1);
                articleY += 180;
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration form = new Registration();
            form.ShowDialog();
        }

        private void label_author_Click(object sender, EventArgs e)
        {
            AuthorStat newAuthor = new AuthorStat();
            newAuthor.name = "1";
            newAuthor.Views = 58;
            newAuthor.Likes = 15;
            newAuthor.DisLikes = 2;
            stat.Add(newAuthor);

            AuthorStat newAuthor2 = new AuthorStat();
            newAuthor2.name = "2";
            newAuthor2.Views = 46;
            newAuthor2.Likes = 95;
            newAuthor2.DisLikes = 4;
            stat.Add(newAuthor2);

            AuthorStat newAuthor3 = new AuthorStat();
            newAuthor3.name = "3";
            newAuthor3.Views = 984;
            newAuthor3.Likes = 65;
            newAuthor3.DisLikes = 14;
            stat.Add(newAuthor3);
            List_of_author form2 = new List_of_author(stat);
            form2.ShowDialog();
        }

        private void categories_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoriesForm form3 =new CategoriesForm(false);
            form3.ShowDialog();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AdvertisingForm form = new AdvertisingForm();
            form.ShowDialog();
        }

        private void Реклама2_Click(object sender, EventArgs e)
        {
            Label newLab = new Label();
            newLab.Location = new Point(30, 500);
            newLab.Text = "sdgdfg";
            Centr_panel.Controls.Add(newLab);
        }

        private void GhostMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLClass.CloseConnection();
        }
        
        
        private void button_login_Click(object sender, EventArgs e)
        {
            List<String> AuthorLoginData = SQLClass.Select
                ("SELECT COUNT(*) FROM " +Tables.AUTHORS + 
                " WHERE UserName = '" + textBox_login.Text + "'");

            bool author = (AuthorLoginData.Count > 0);

            if (author)
            {
                Users.CURRENT_USER = textBox_login.Text;
                AuthorMainForm af = new AuthorMainForm(textBox_login.Text);
                af.ShowDialog();
                Form1_Load(sender, e);
            }
               
            else
            {
                To_come_in.LogIntoAdminZone(textBox_login.Text, textBox_password.Text);
                Form1_Load(sender, e);
            }
        }

        private void button_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(sender, null);
            }
        }
        
        private void reclama_Click(object sender, EventArgs e)
        {

        }

        private void Centr_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butto_search_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butto_search_Click(sender, null);
            }
        }

        private void label_popular_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox_search.Text = ((Label)sender).Text;
            butto_search_Click(sender, e);
        }
    }
}