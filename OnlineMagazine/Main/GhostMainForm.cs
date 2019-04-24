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

namespace OnlineMag
{
    public partial class GhostMainForm : Form
    {
        List<PictureBox> pb = new List<PictureBox>();
        /// <summary>
        /// Последний поисковый запрос
        /// </summary>
        public static String LAST_SEARCH = "";
        /// <summary>
        /// Видимость кабинета админа
        /// </summary>
        public static bool IS_ADMIN;
        /// <summary>
        /// Видимость кабинета автора
        /// </summary>
        public static bool IS_AUTHOR;

        public static List<AuthorStat> stat = new List<AuthorStat>();
        public List<LinkLabel> arts = new List<LinkLabel>();
        public List<PictureBox> piccc = new List<PictureBox>();
        WebClient client = new WebClient();
        public string[] url = new string[50];
        int kolvo_nazatiy = 0;
        public string kuda_i_kak;
        public int articleY = 50;
        

        public GhostMainForm()
        {
            UCFunctions.AddUC(this);
            InitializeComponent();
            Configs.ZAGOLOVOK_FONT = popularArticlesLabel.Font;
            label_Author_header.Font = Configs.ZAGOLOVOK_FONT;
            label_cats_header.Font = Configs.ZAGOLOVOK_FONT;

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

        #region Порядок сортировки статей и авторов
        String GetArticlesSortOrder()
        {
            string sortOrder = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    sortOrder = "";
                    break;
                case 1:
                    sortOrder = "ORDER BY A ASC";
                    break;
                case 2:
                    sortOrder = "ORDER BY A DESC";
                    break;
                case 3:
                    sortOrder = "ORDER BY Likes.LikesCount - Likes.DisCount ASC";
                    break;
                case 4:
                    sortOrder = "ORDER BY Likes.LikesCount - Likes.DisCount DESC";
                    break;
                case 5:
                    sortOrder = "ORDER BY LikesCount ASC";
                    break;
                case 6:
                    sortOrder = "ORDER BY LikesCount DESC";
                    break;
            }

            return sortOrder;
        }
        
        String GetAuthorSortOrder()
        {
            string sortOrder = "";
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    sortOrder = "";
                    break;
                case 1:
                    sortOrder = "ORDER BY prosmot ASC";
                    break;
                case 2:
                    sortOrder = "ORDER BY prosmot DESC";
                    break;
                case 3:
                    sortOrder = "ORDER BY LikesCount - DisLikesCount ASC";
                    break;
                case 4:
                    sortOrder = "ORDER BY LikesCount - DisLikesCount DESC";
                    break;
                case 5:
                    sortOrder = "ORDER BY LikesCount ASC";
                    break;
                case 6:
                    sortOrder = "ORDER BY LikesCount DESC";
                    break;
                case 7:
                    sortOrder = "ORDER BY Arts ASC";
                    break;
                case 8:
                    sortOrder = "ORDER BY Arts DESC";
                    break;
            }

            return sortOrder;
        }
        #endregion
        
        private void ArticleClick(object sender, EventArgs e)
        {
            foreach (LinkLabel lab in arts)
            {
                if (sender.Equals(lab))
                {
                    statiya stat = statiya.Click1(((Label)sender).Text);
                    StatiyaForm OknoStatiya = new StatiyaForm(stat);
                    OknoStatiya.ShowDialog();
                    LAST_SEARCH = textBox_search.Text;
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
            Left_panel.Controls.RemoveByKey("UCref");
            Right_panel.Controls.Clear();
            UCFunctions.AddUC(this);
            //Left_panel.Controls.Add(new AuthenticationUserControl(new List<string>()) { Location = new Point(0,0), Dock = DockStyle.Top , Name = "qq"});
            GC.Collect();
            GC.WaitForPendingFinalizers();
            arts.Clear();
            
            //textBox_password.UseSystemPasswordChar = true;
            Right_panel.Controls.Add(comboBox2);
            //Right_panel.Controls.Add(button_add_reklama);
            //Right_panel.Controls.Add(button1);
            
           // button_add_reklama.Visible = false;
                
            lable_name_of_polzovatel.Text = Users.CURRENT_USER;
            AdmButton.Visible = IS_ADMIN;
            AutButton.Visible = IS_AUTHOR;
          

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

            

            List<String> authorsList = SQLClass.Select("SELECT UserName, " +

                " IFNULL((SELECT SUM(LikesCount) FROM " + Tables.LIKES + " WHERE Author = UserName), 0) LikesCount," +
                " IFNULL((SELECT COUNT(Header) FROM " + Tables.ARTICLES + " WHERE Author = UserName), 0) Arts," +
                " IFNULL((SELECT SUM(DisCount) FROM " + Tables.LIKES + "  WHERE Author = UserName), 0) DisLikesCount," +
                " IFNULL((SELECT COUNT(*) FROM " + Tables.READ_OF_ARTICLES + " WHERE name_of_article IN (SELECT Header FROM " + Tables.ARTICLES + " WHERE Author = UserName)), 0)  prosmot" +

                " FROM " + Tables.AUTHORS + " " +
                GetAuthorSortOrder() +
                " LIMIT 0, " + Configs.KOL_VO_ELEMENTOV_Author);

            int authorsY = 75;
            for (int artIndex = 0; artIndex < authorsList.Count; artIndex += 5)
            {
                Label label1 = new Label();
                label1.Location = new Point(0, authorsY);
                label1.Size = new Size(100, 20);
                label1.Text = authorsList[artIndex].ToString();
                label1.Click += new System.EventHandler(AuthorOrCategorySelect);
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

            List<String> catsList = SQLClass.Select("SELECT Name FROM " + Tables.CATEGORIES + " LIMIT 0, " + Configs.KOL_VO_ELEMENTOV_Categoriya);
            
            for (int artIndex = 0; artIndex < catsList.Count; artIndex++)
            {
                Label label1 = new Label();
                label1.Location = new Point(0, catY);
                label1.Size = new Size(100, 20);
                label1.Text = catsList[artIndex].ToString();
                label1.Click += new System.EventHandler(AuthorOrCategorySelect);
                Right_panel.Controls.Add(label1);
                catY += 28;
            }
            categories_linklabel.Location = new Point(0, catY + 5);
            #endregion

            #region Обновление списка подборок
            label_collections.Location = new Point(6, catY + 28);
            Right_panel.Controls.Add(label_collections);
            List<String> collList = SQLClass.Select("SELECT DISTINCT Coll_text FROM " + Tables.COLLECTION + 
                " LIMIT 0, " + Configs.KOL_VO_ELEMENTOV_Podborka);

            int collY = catY + 28 + 24;
            for (int colIndex = 0; colIndex < collList.Count; colIndex++)
            {
                Label collLabel = new Label();
                collLabel.Location = new Point(0, collY);
                collLabel.Size = new Size(100, 20);
                collLabel.Text = collList[colIndex].ToString();
                collLabel.Click += new EventHandler(AuthorOrCategorySelect);
                Right_panel.Controls.Add(collLabel);
                collY += 28;
            }
            #endregion          

            #region Advertising

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

            #endregion

            textBox_search.Text = LAST_SEARCH;
            Search_Click(sender, e);
            //reclamaPanel_MouseLeave(sender, e);

            //Добавление UserControl-а категорий
            /*
            List<string> p = new List<string>() { "5", "2" };
            CategoriesUserControl b = new CategoriesUserControl(p);
            b.Dock = DockStyle.Bottom;
            Right_panel.Controls.Add(b);
            */
        }    

        /// <summary>
        /// Поиск
        /// </summary>
        private void Search_Click(object sender, EventArgs e)
        {
            Centr_panel.Controls.Clear();

            //textBox_login.Text = "";
            //textBox_password.Text = "";

            kolvo_nazatiy = 0;
            dalee_Click(sender, e);

            Centr_panel.Controls.Add(dalee);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration form = new Registration("");
            form.ShowDialog();
        }

        /// <summary>
        /// Клик на всех авторов
        /// </summary>
        private void label_author_Click(object sender, EventArgs e)
        {
            List_of_author form2 = new List_of_author();
            form2.ShowDialog(); 
            formloader(sender, e);
        }


        /// <summary>
        /// Клик на все категории
        /// </summary>
        public void categories_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoriesForm form3 = new CategoriesForm(false);
            form3.ShowDialog(); 
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
            /*
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

            IS_AUTHOR = (AuthorLoginData[0] != "0");
            IS_ADMIN = (label_password.Text != "" && To_come_in.LogIntoAdminZone(textBox_login.Text, textBox_password.Text));
            Users.CURRENT_USER = "NONAME";
            if (!IS_AUTHOR && !IS_ADMIN && Polzovatel[0] == "0")
            {
                MessageBox.Show("Вас в безе нет (Не верен пароль или логин)");
            }
            else
            {
                Users.CURRENT_USER = textBox_login.Text;
            }
            

            GC.Collect();
            GC.WaitForPendingFinalizers();
            formloader(sender, e);
            */
        }

        private void button_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(sender, null);
            }
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Click(sender, null);
            }
        }

        /// <summary>
        /// КЛик на автора / категорию
        /// </summary>
        public void AuthorOrCategorySelect(object sender, EventArgs e)
        {
            textBox_search.Text = ((Label)sender).Text;
            Search_Click(sender, e);
        }
        
        private void dalee_Click(object sender, EventArgs e)
        {
            piccc = new List<PictureBox>();
            pb = new List<PictureBox>();
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



            List<string> PopularArticles =
                SQLClass.Select("SELECT Header " + 
                " FROM " + Tables.ARTICLES +
                " WHERE new = 0 " + nahod +
                GetArticlesSortOrder() + 
                " LIMIT " + Convert.ToString(kolvo_nazatiy * 3) + ", 3", dict);

            int ii = 0;
            foreach (string ArticleName in PopularArticles)
            {
                Centr_panel.Controls.Add(new ArticlePreviewUserControl(new List<string>() { ArticleName })
                {
                    Location = new Point(0, ii)
                });
                ii += 180;
            }

            kolvo_nazatiy++;
        }

        void click(object sender, EventArgs e)
        {
            foreach (PictureBox pbn in pb)
            {
                if (sender.Equals(pbn))
                {
                    bool isLike = true;
                    pictureBoxLike_Clicking1(pbn.Tag.ToString(), isLike);
                    isLike = false;
                    formloader(sender, e);
                    break;
                }
            }
        }

        public static void pictureBoxLike_Clicking1(String Text, bool isLike)
        {
            

            List<String> textesAut = SQLClass.Select("SELECT Author, Category FROM " + Tables.ARTICLES + " WHERE `Header` = '" + Text + "'");

            List<String> likes = SQLClass.Select("SELECT Article FROM " + Tables.LIKES + " WHERE Article = '" + Text + "'");
            if (isLike)
            {
                if (likes.Count > 0)
                {
                    SQLClass.Update("UPDATE " + Tables.LIKES +
                        " SET LikesCount = LikesCount + 1" +
                        " WHERE Article = '" + Text + "'");
                }
                else
                {
                    SQLClass.Insert(
                        "INSERT INTO " + Tables.LIKES +
                        "(Article, Author, Category, LikesCount, DisCount)" +
                        " VALUES (" +
                        "'" + Text + "'" +
                        ", '" + textesAut[0] + "'" +
                        ", '" + textesAut[1] + "'" +
                        ",1" +
                        ",0)");
                }

            }
            else
            {
                SQLClass.Update("UPDATE " + Tables.LIKES +
                    " SET LikesCount = LikesCount - 1" +
                    " WHERE Article = '" + Text + "'");
            }
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

        private void showPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textBox_password.UseSystemPasswordChar = !textBox_password.UseSystemPasswordChar;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void reclamaPanel_MouseLeave(object sender, EventArgs e)
        {
            AdsUserControl recl = new AdsUserControl(new List<string>() { "5", "20" });
            reclamaPanel.Controls.Add(recl);
        }

        /// <summary>
        /// Обновление юзера, поисковых запросов в таймере
        /// </summary>
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            //FIXME!!! Еще будет автор, просто поисковый запрос. Тут посложнее иф, друзья))
            if (textBox_search.Text != Configs.SELECTED_CATEGORY && !String.IsNullOrEmpty(Configs.SELECTED_CATEGORY))
            {
                textBox_search.Text = Configs.SELECTED_CATEGORY;
                Search_Click(sender, e);
            }

            if (Users.CURRENT_USER != Users.OLD_CURRENT_USER)
            {
                Users.OLD_CURRENT_USER = Users.CURRENT_USER;
                formloader(sender, null);
            }
        }
    }
}