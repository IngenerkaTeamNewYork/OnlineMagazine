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

        public static ContextMenuStrip DeleteMenuStrip;

        public static ContextMenuStrip LabelMenu;

        public GhostMainForm()
        {
            UCFunctions.AddUC(this);
            DesignClass.AddContextMenuStrip(this);
            InitializeComponent();
            Configs.ZAGOLOVOK_FONT = popularArticlesLabel.Font;
            //label_Author_header.Font = Configs.ZAGOLOVOK_FONT;
          
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
                    Statiya stat = Statiya.GetStatiyaFromArticleName(((Label)sender).Text);
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
                    Statiya stat = Statiya.GetStatiyaFromArticleName(lab.Tag.ToString());
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
            this.ContextMenuStrip = Program.AddNewUserControlCMS;
            Program.LabelControlCMS = LabelContextMenuStrip1;

            foreach (Control Ctrl in this.Controls)
            {
                if (Ctrl.GetType().ToString() == "System.Windows.Forms.Panel")
                {
                    Ctrl.ContextMenuStrip = Program.AddNewUserControlCMS;
                    foreach (Control Ct in Ctrl.Controls)
                    {
                        if (Ct.GetType().ToString() == "System.Windows.Forms.Panel")
                        {
                            Ct.ContextMenuStrip = Program.AddNewUserControlCMS;
                        }
                    }
                }
                
               
            }

            Menus.InitAddUserControls(ref ArticlecontextMenuStrip1);
            Left_panel.Controls.RemoveByKey("UCref");
            RightSubPanel.Controls.RemoveByKey("UCref");
            RightSubPanel.Controls.Clear();
            reclamaPanel.Controls.Clear();
            UCFunctions.AddUC(this);
            //Left_panel.Controls.Add(new AuthenticationUserControl(new List<string>()) { Location = new Point(0,0), Dock = DockStyle.Top , Name = "qq"});
            GC.Collect();
            GC.WaitForPendingFinalizers();
            arts.Clear();
            //textBox_password.UseSystemPasswordChar = true;
            // button_add_reklama.Visible = false;

            lable_name_of_polzovatel.Text = Users.CURRENT_USER;
            AdmButton.Visible = IS_ADMIN;
            AutButton.Visible = IS_AUTHOR;
            button2.Visible = false;

            if (IS_ADMIN)
            {
                button2.Visible = true;
            }
          /*  #region Advertising

            reclamaPanel.Controls.Clear();
            AdsUserControl recl = new AdsUserControl(new List<string>() { "5", "20" });
            reclamaPanel.Controls.Add(recl);

            #endregion*/

            textBox_search.Text = LAST_SEARCH;
            Search_Click(sender, e);
            popularArticlesLabel.ContextMenuStrip = Program.LabelControlCMS;
        }    

        /// <summary>
        /// Поиск
        /// </summary>
        public void Search_Click(object sender, EventArgs e)
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
        public static void reclama_Click(object sender, EventArgs e)
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
            /*MozhnoVvoditBukvyVPoisk = true;
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(sender, null);
            }*/
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            MozhnoVvoditBukvyVPoisk = true;
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
            
        }
        
        private void dalee_Click(object sender, EventArgs e)
        {
            piccc = new List<PictureBox>();
            pb = new List<PictureBox>();
            string[] dhfg = textBox_search.Text.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string nahod = "";
            /*Dictionary<String, String> dict = new Dictionary<string, string>();
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
            }*/

            Dictionary<String, String> dict = new Dictionary<string, string>();
            dict.Add("STR", "%" + textBox_search.Text + "%");

            List<String> PopularArticles = SQLClass.Select
                ("SELECT Header, " +
                "(SELECT COUNT(*) FROM read_of_articles WHERE Articles1.Header = read_of_articles.name_of_article ) A" +
                " FROM " + Tables.ARTICLES + ", " + Tables.LIKES +
                " WHERE new = 0 AND  " + Tables.ARTICLES + ".Header = " + Tables.LIKES + ".Article  AND  (header like @STR" +
                " OR " + Tables.ARTICLES + ".category like @STR" +
                " OR " + Tables.ARTICLES + ".author like @STR)" + GetAuthorSortOrder() + " LIMIT 0, 3", dict);

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
          /*  fontDialog1.ShowColor = true;

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
            }*/
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
            
        }

        public static bool MozhnoVvoditBukvyVPoisk = true;

        /// <summary>
        /// Обновление юзера, поисковых запросов в таймере
        /// </summary>
        public void mainTimer_Tick(object sender, EventArgs e)
        {
            if (IS_ADMIN)
            {
                this.ContextMenuStrip = Program.AddNewUserControlCMS;
                Program.UserControlCMS = UCContextMenuStrip;
                Program.AddNewUserControlCMS = ArticlecontextMenuStrip1;
            }
            else
            {
                Program.UserControlCMS = null;
                Program.AddNewUserControlCMS = null;
            }
            //IT DOESN'T WORK! 

            //FIXME!!! Еще будет автор, просто поисковый запрос. Тут посложнее иф, друзья))
            if (MozhnoVvoditBukvyVPoisk)
            {
                return;
            }
            if (textBox_search.Text != Configs.SELECTED_CATEGORY && !String.IsNullOrEmpty(Configs.SELECTED_CATEGORY))
            {
                textBox_search.Text = Configs.SELECTED_CATEGORY;
                PodborkiUserControl.search = "";
                Search_Click(sender, e);
            }

            if (textBox_search.Text != PodborkiUserControl.search && !String.IsNullOrEmpty(PodborkiUserControl.search))
            {
                textBox_search.Text = PodborkiUserControl.search;
                Configs.SELECTED_CATEGORY = "";
                Search_Click(sender, e);
            }

            if (Users.CURRENT_USER != Users.OLD_CURRENT_USER)
            {
                Users.OLD_CURRENT_USER = Users.CURRENT_USER;
                formloader(sender, null);
            }

            MozhnoVvoditBukvyVPoisk = true;
        }

        private void reclamaPanel_Paint(object sender, PaintEventArgs e)
        {
        }
           
        private void GhostMainForm_Resize(object sender, EventArgs e)
        {
            Centr_panel.Width = this.Width - Right_panel.Width - Left_panel.Width - 40;
            Centr_panel.Height = this.Height - Centr_panel.Location.Y;
            foreach (Control ctrl in Centr_panel.Controls)
            {

                if (ctrl.GetType().ToString() == "OnlineMag.ArticlePreviewUserControl")
                {
                    int oldWidth = ctrl.Width;
                    if (oldWidth > 0)
                    {
                        ctrl.Width = this.Width - Right_panel.Width - Left_panel.Width - 40;
                        ctrl.Height = ctrl.Height * ctrl.Width / oldWidth;
                    }
                    /*foreach (Control ct in ctrl.Controls)
                    {
                        if (ct.GetType().ToString() == "System.Windows.Forms.PictureBox")
                        {
                            int oldW = ct.Width;
                            if (oldW > 0)
                            {
                                ct.Width = this.Width - Right_panel.Width - Left_panel.Width;
                                ct.Height = ct.Height * ct.Width / oldW;
                            }
                        }
                    }*/
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menus.DeleteUserControl(sender, e);
        }

        private void настроитьПараметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menus.SetUCParametersToCurrent(sender, e);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            MozhnoVvoditBukvyVPoisk = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UCContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
        }
       
        public void dockClick(object sender, EventArgs e)
        {
           String srt = ((ToolStripMenuItem)sender).Text.Replace("Dock.", "");
            UserControl uc = (UserControl)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            SQLClass.Update("UPDATE block SET" +
               " Dock = '"+ srt + "' WHERE id = '" + uc.Tag + "'");
            switch(srt)
            {
                case "Top":
                    uc.Dock = DockStyle.Top;
                    break;
                case "Right":
                    uc.Dock = DockStyle.Right;
                    break;
                case "Left":
                    uc.Dock = DockStyle.Left;
                    break;
                case "Fill":
                    uc.Dock = DockStyle.Fill;
                    break;
                case "Bottom":
                    uc.Dock = DockStyle.Bottom;
                    break;
                case "None":
                    uc.Dock = DockStyle.None;
                    break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LabelUniqueForm d = new LabelUniqueForm(popularArticlesLabel);
            d.ShowDialog();
        }

        private void ИзменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl.GetType().Name)
            {
                case "label":
                    Label pb = (Label)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
                    LabelUniqueForm f = new LabelUniqueForm(pb);
                    f.ShowDialog();
                    pb = f.newLabel;
                    LabelUniqueForm.UpdateLabelDesignInDb(pb);
                    break;
                case "Button":
                    Button pb1 = (Button)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
                    ButtonUniqueForm f1 = new ButtonUniqueForm(pb1);
                    f1.ShowDialog();
                    pb1 = f1.newButton;
                    LabelUniqueForm.UpdateLabelDesignInDb(pb1);
                    break;
            }
        }
    }
}