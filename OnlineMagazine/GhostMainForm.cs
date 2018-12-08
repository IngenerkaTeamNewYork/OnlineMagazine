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

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class GhostMainForm : Form
    {

        public static bool adm;

        public static List<AuthorStat> stat = new List<AuthorStat>();
        public static bool aut;
        public List<LinkLabel> arts = new List<LinkLabel>();
        public List<PictureBox> piccc = new List<PictureBox>();
        WebClient client = new WebClient();
        public string[] url = new string[50];
        int kolvo_nazatiy = 0;
        public string kuda_i_kak;
        public int articleY = 50;
        

        public GhostMainForm()
        {
            InitializeComponent();
            Configs.ZAGOLOVOK_FONT = popularArticlesLabel.Font;
            label_Author_header.Font = Configs.ZAGOLOVOK_FONT;

            label_cats_header.Font = Configs.ZAGOLOVOK_FONT;
            //label_popular.Text = stat.kategorita_statii;
            SQLClass.OpenConnection();
            
            AdmButton.Visible = false;
            AutButton.Visible = false;
        }

        void formloader(object sender, EventArgs e)
        {
            piccc = new List<PictureBox>();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Form1_Load(sender, e);
        }

        String getKak()
        {
            string kak = "";
            //Жуков!!! Selected, а не tab
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    kak = "";
                    break;
                case 1:
                    kak = "ORDER BY A ASC";
                    break;
                case 2:
                    kak = "ORDER BY A DESC";
                    break;
                case 3:
                    kak = "ORDER BY Likes.LikesCount - Likes.DisCount ASC";
                    break;
                case 4:
                    kak = "ORDER BY Likes.LikesCount - Likes.DisCount DESC";
                    break;
                case 5:
                    kak = "ORDER BY LikesCount ASC";
                    break;
                case 6:
                    kak = "ORDER BY LikesCount DESC";
                    break;
            }

            return kak;
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
                    formloader(sender, e);
                    break;
                }
            }
        }

        private void clik_na_pic(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            foreach (PictureBox lab in piccc)
            {
                if (sender.Equals(lab))
                {
                    statiya stat = statiya.Click1(lab.Tag.ToString());
                    //StatiyaForm OknoStatiya = new StatiyaForm(stat);
                    VipStatiy OknoStatiya = new VipStatiy(stat);
                    OknoStatiya.ShowDialog();
                    formloader(sender, e);
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            arts.Clear();
            Right_panel.Controls.Clear();
            textBox_password.UseSystemPasswordChar = true;
            //Right_panel.Controls.Add(button_add_reklama);
            //Right_panel.Controls.Add(button1);
            
           // button_add_reklama.Visible = false;
                
            lable_name_of_polzovatel.Text = Users.CURRENT_USER;
            AdmButton.Visible = adm;
            AutButton.Visible = aut;

            if (lable_name_of_polzovatel.Text != "NONAME")
            {
                lable_name_of_polzovatel.Text = "Вы вошли как " + Users.CURRENT_USER;
                Right_panel.Controls.Add(lable_name_of_polzovatel);

                Right_panel.Controls.Add(tableLayoutPanel2);
                button_add_reklama.Visible = true;
                button1.Visible = true;
            }

            #region Обновление списка авторов

            Right_panel.Controls.Add(label_Author_header);
            Right_panel.Controls.Add(label_author);

            

            List<String> authorsList = SQLClass.Select("SELECT UserName FROM " + Tables.AUTHORS + " LIMIT 0, " + Configs.KOL_VO_ELEMENTOV);

            int authorsY = 75;
            for (int artIndex = 0; artIndex < authorsList.Count; artIndex++)
            {
                Label label1 = new Label();
                label1.Location = new Point(0, authorsY);
                label1.Size = new Size(100, 20);
                label1.Text = authorsList[artIndex].ToString();
                label1.Click += new System.EventHandler(Search_CLick);
                Right_panel.Controls.Add(label1);
                authorsY += 25;

            }
            label_author.Location = new Point(3, authorsY);
            #endregion

            #region Обновление списка категорий

            Right_panel.Controls.Add(label_cats_header);
            Right_panel.Controls.Add(categories_linklabel);



            label_cats_header.Location = new Point(0, authorsY + 25);
            int catY = authorsY + 50;

            List<String> catsList = SQLClass.Select("SELECT Name FROM " + Tables.CATEGORIES + " LIMIT 0, " + Configs.KOL_VO_ELEMENTOV);

            
            for (int artIndex = 0; artIndex < catsList.Count; artIndex++)
            {
                Label label1 = new Label();
                label1.Location = new Point(0, catY);
                label1.Size = new Size(100, 20);
                label1.Text = catsList[artIndex].ToString();
                label1.Click += new System.EventHandler(Search_CLick);
                Right_panel.Controls.Add(label1);
                catY += 28;
            }
            categories_linklabel.Location = new Point(0, catY + 5);
            #endregion

            #region Обновление списка подборок
            label_collections.Location = new Point(6, catY + 28);
            Right_panel.Controls.Add(label_collections);


            List<String> collList = SQLClass.Select("SELECT DISTINCT `Coll_text`  FROM " + Tables.COLLECTION + " LIMIT 0, " + Configs.KOL_VO_ELEMENTOV);

            int collY = catY + 28 + 50;
            for (int artIndex = 0; artIndex < collList.Count; artIndex++)
            {
                Label label1 = new Label();
                label1.Location = new Point(0, collY);
                label1.Size = new Size(100, 20);
                label1.Text = collList[artIndex].ToString();
                label1.Click += new System.EventHandler(Search_CLick);
                Right_panel.Controls.Add(label1);
                collY += 28;
            }
            #endregion

          

            #region Advertising

            /*List<String> s = Advertising.GetRandom();
            reclama.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama.LoadAsync(s[0]);
            reclama.Tag = s[1];
            reclama.Location = Configs.Rpont;
            reclama.Width=226;
            reclama.Height = 439/Configs.ChR;
            reclama.Location = Configs.Rpont;*/

            reclamaPanel.Controls.Clear();
            int Y = Configs.Rpont.Y;
            for (int i = 0; i < Configs.ChR; i++)
            {
                PictureBox reclama1 = new PictureBox();
                List<String> s = Advertising.GetRandom();
                reclama1.SizeMode = PictureBoxSizeMode.StretchImage;
                reclama1.LoadAsync(s[0]);
                reclama1.Tag = s[1];
                reclama1.Width = reclamaPanel.Width;
                reclama1.Height = reclamaPanel.Height / Configs.ChR;
                reclama1.Location = new Point(10, Y);
                reclama1.Click += new System.EventHandler(reclama_Click);
                Y = Y + reclama1.Height;
                reclamaPanel.Controls.Add(reclama1);

            }


            /*    s = Advertising.GetRandom();
            reclama2.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama2.LoadAsync(s[0]);
            reclama3.Tag = s[1];

            s = Advertising.GetRandom();
            reclama3.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama3.LoadAsync(s[0]);
            reclama3.Tag = s[1];*/
            #endregion

            textBox_search.Text = "";
            butto_search_Click(sender, e);


            textBox_search.Text = "Поиск";
        }    


        private void butto_search_Click(object sender, EventArgs e)
        {
            Centr_panel.Controls.Clear();

            textBox_login.Text = "";
            textBox_password.Text = "";

            kolvo_nazatiy = 0;
            dalee_Click(sender, e);

            /*Dictionary<String, String> dict = new Dictionary<string, string>();
            dict.Add("STR", "%" + textBox_search.Text + "%");
            
            List <String> PopularArticles = SQLClass.Select
                ("SELECT Header, Picture, likesCount, discount, "+
                "(SELECT COUNT(*) FROM read_of_articles WHERE Articles1.Header = read_of_articles.name_of_article ) A" +
                " FROM " + Tables.ARTICLES + ", " + Tables.LIKES +
                " WHERE new = 0 AND  " + Tables.ARTICLES + ".Header = " + Tables.LIKES + ".Article  AND  (header like @STR" +
                " OR " + Tables.ARTICLES + ".category like @STR" +
                " OR " + Tables.ARTICLES + ".author like @STR)" + getKak() + " LIMIT 0, 3", dict);
            
            int articleY = 10;

            for (int artIndex = 0; artIndex < PopularArticles.Count; artIndex += 5)
            {
                #region Article header
                Panel articleHeaderPanel = new Panel();
                articleHeaderPanel.Size = new Size(Centr_panel.Width, 30);
                articleHeaderPanel.Dock = DockStyle.Top;
                articleHeaderPanel.TabIndex = 1;
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
                    web.ScrollBarsEnabled = false;
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
                            artImage.Image = new Bitmap("defolt_statiy.jpg");
                        }
                    }

                    Centr_panel.Controls.Add(artImage);
                    piccc.Add(artImage);
                }

                arts.Add(label1);
                articleY += 180;
            }*/

            Centr_panel.Controls.Add(dalee);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration form = new Registration("");
            form.ShowDialog();
        }

        private void label_author_Click(object sender, EventArgs e)
        {
            List_of_author form2 = new List_of_author();
            form2.ShowDialog(); 
            formloader(sender, e);
        }

        private void categories_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoriesForm form3 = new CategoriesForm(false);
            form3.ShowDialog(); 
            formloader(sender, e);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AdvertisingForm form = new AdvertisingForm();
            form.ShowDialog();
        }

        private void GhostMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLClass.CloseConnection();
            piccc = new List<PictureBox>();
        }
        
        /// <summary>
        /// Функция клика на рекламу
        /// </summary>
        private void reclama_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(((PictureBox)sender).Tag.ToString()); 
            }
            catch (Exception)
            { 
                Process.Start("https://www.yandex.ru"); 
            }
        }
        
        private void button_login_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Dictionary<String, String> dict = new Dictionary<string, string>();
            dict.Add("STR", textBox_login.Text);
            dict.Add("PASS", textBox_password.Text);
            Users.CURRENT_USER = textBox_login.Text;

            List<String> AuthorLoginData = SQLClass.Select
                ("SELECT COUNT(*) FROM " + Tables.AUTHORS +
                " WHERE UserName = @STR " +
                " AND UserName IN (SELECT Login FROM " + Tables.POLZOVATELI +
                " WHERE Login = @STR and Parol = @PASS)", dict);

            List<String> Polzovatel = SQLClass.Select
                ("SELECT COUNT(*) FROM " + Tables.POLZOVATELI +
                " WHERE Login = @STR and Parol = @PASS", dict);

            aut = (AuthorLoginData[0] != "0");
            adm = (label_password.Text != "" && To_come_in.LogIntoAdminZone(textBox_login.Text, textBox_password.Text));
            Users.CURRENT_USER = textBox_login.Text;
            if (!aut && !adm && Polzovatel[0] == "0")
            {
                MessageBox.Show("Вас в безе нет (Не верен пароль или логин)");
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            formloader(sender, e);
        }

        private void button_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(sender, null);
            }
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

        /// <summary>
        /// КЛик на автора / категорию
        /// </summary>
        private void Search_CLick(object sender, EventArgs e)
        {
            textBox_search.Text = ((Label)sender).Text;
            butto_search_Click(sender, e);
        }

        private void Collections_CLick(object sender, EventArgs e)
        {
            textBox_search.Text = ((Label)sender).Text;
            butto_search_Click(sender, e);
        }


           


        private void dalee_Click(object sender, EventArgs e)
        {
            piccc = new List<PictureBox>();
            string[] dhfg = textBox_search.Text.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string nahod = "";
            Dictionary<String, String> dict = new Dictionary<string, string>();
            for (int i = 0; i < dhfg.Length; i++)
            {
                dict.Add("STR" + i.ToString(), "%" + dhfg[i] + "%");
                if (i > 0)
                {
                    nahod += " OR ";
                }
                nahod += "header like @STR" + i.ToString() + 
                    " OR category like @STR" + i.ToString() + 
                    " OR author like @STR" + i.ToString() +
                    " OR artic_id IN (SELECT id_art FROM " + Tables.COLLECTION + " WHERE Coll_text like @STR" + i.ToString() + " )";

            }

            if (nahod!= "")
            {
                nahod = " AND (" + nahod + ")";
            }



            List<String> PopularArticles =
                SQLClass.Select
                ("SELECT Header, Picture, " + 
                "(SELECT likesCount FROM " + Tables.LIKES + " WHERE Header = Article) likesCount, " +
                "(SELECT discount FROM " + Tables.LIKES + " WHERE Header = Article) discount, " +
                "(SELECT COUNT(*) FROM " + Tables.READ_OF_ARTICLES + " WHERE Header = name_of_article) A" +
                " FROM " + Tables.ARTICLES +
                " WHERE new = 0 " + nahod +
                getKak() + 
                " LIMIT " + Convert.ToString(kolvo_nazatiy * 3) + ", 3", dict);


            for (int artIndex = 0; artIndex < PopularArticles.Count; artIndex += 5)
            {
                #region Article header
                Panel articleHeaderPanel = new Panel();
                articleHeaderPanel.Size = new Size(Centr_panel.Width, 30);
                articleHeaderPanel.Dock = (kolvo_nazatiy > 0) ? DockStyle.Bottom : DockStyle.Top;
                articleHeaderPanel.TabIndex = (kolvo_nazatiy > 0) ? 3 * kolvo_nazatiy : 3 * kolvo_nazatiy + 2;
                
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
                    web.TabIndex = 3 * kolvo_nazatiy + 1;
                    web.Dock = (kolvo_nazatiy > 0) ? DockStyle.Bottom : DockStyle.Top;
                    web.DocumentText = string.Format(embed, url);
                    web.Location = new Point(0, articleY + 25);

                    if (kolvo_nazatiy > 0)
                    {
                        Centr_panel.Controls.Add(web);
                        Centr_panel.Controls.Add(articleHeaderPanel);
                    }
                    else
                    {
                        Centr_panel.Controls.Add(articleHeaderPanel);
                        Centr_panel.Controls.Add(web);
                    }
                }
                //Picture
                else
                {
                    String[] chasti_stroki = PopularArticles[artIndex + 1].ToString().Split(new char[] { ' ', '/' });

                    PictureBox artImage = new PictureBox();
                    artImage.Location = new Point(0, articleY + 25);
                    artImage.Tag = label1.Text;
                    artImage.Size = new Size(Centr_panel.Width, 150);
                    artImage.Dock = (kolvo_nazatiy > 0) ? DockStyle.Bottom : DockStyle.Top;
                    artImage.Click += new System.EventHandler(clik_na_pic);
                    artImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    artImage.TabIndex = 3 * kolvo_nazatiy + 1;

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
                            artImage.Image = new Bitmap("defolt_statiy.jpg");
                        }
                    }

                    if (kolvo_nazatiy > 0)
                    {
                        Centr_panel.Controls.Add(artImage);
                        Centr_panel.Controls.Add(articleHeaderPanel);
                    }
                    else
                    {
                        Centr_panel.Controls.Add(articleHeaderPanel);
                        Centr_panel.Controls.Add(artImage);
                    }

                    piccc.Add(artImage);
                }

                Centr_panel.Controls.Add(dalee);
                arts.Add(label1);
                articleY += 180;
            }

            kolvo_nazatiy++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = this.Font;
            fontDialog1.Color = this.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                ColorDialog MyDialog = new ColorDialog
                {
                    AllowFullOpen = false,
                    ShowHelp = true,
                    Color = popularArticlesLabel.ForeColor
                };

                if (MyDialog.ShowDialog() == DialogResult.OK)
                {
                    popularArticlesLabel.ForeColor = MyDialog.Color;
                }

                if (fontDialog1.Font.Size > 5 && fontDialog1.Font.Size < 38)
                {
                    this.Font = fontDialog1.Font;
                    Configs.USER_FONT = fontDialog1.Font;
                }
                this.ForeColor = MyDialog.Color;
                Configs.USER_COLOR = MyDialog.Color;
            }
        }

        private void Right_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void увеличитьПисюнToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = !textBox_password.UseSystemPasswordChar;
        }

        private void AdmButton_Click(object sender, EventArgs e)
        {
            Form ifrm = new AdminMainForm();
            ifrm.ShowDialog();
            formloader(sender, e);
        }

        private void AutButton_Click(object sender, EventArgs e)
        {

                AuthorMainForm af = new AuthorMainForm(Users.CURRENT_USER);
                af.ShowDialog();
           
            
            formloader(sender, e);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}