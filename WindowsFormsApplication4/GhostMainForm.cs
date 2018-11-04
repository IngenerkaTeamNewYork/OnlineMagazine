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

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class GhostMainForm : Form
    {
        public static List<AuthorStat> stat = new List<AuthorStat>();

        public List<LinkLabel> arts = new List<LinkLabel>();
        public List<PictureBox> piccc = new List<PictureBox>();
      
        public string[] url = new string[50];
        int kolvo = 0;
        public string kuda_i_kak;
      
        public GhostMainForm()
        {
            InitializeComponent();


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
                    StatiyaForm1 OknoStatiya = new StatiyaForm1(stat);
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
                    StatiyaForm1 OknoStatiya = new StatiyaForm1(stat);
                    OknoStatiya.ShowDialog();
                }
            }
        }  
      
        private void Form1_Load(object sender, EventArgs e)
        {
            Centr_panel.Controls.Clear();
            Centr_panel.Controls.Add(popularArticlesLabel);

            textBox_login.Text = "";
            textBox_password.Text = "";


            MySqlCommand cmd = new MySqlCommand("SELECT Header, Picture FROM " + Tables.ARTICLES + " WHERE new = 0 LIMIT 0, 3", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            int articleY = 50;
            while (rdr.Read())
            {
                LinkLabel label1 = new LinkLabel();
                label1.Location = new Point(0, articleY);
                label1.Size = new Size(Centr_panel.Width, 20);
                label1.Text = rdr[0].ToString();
                label1.Click += new System.EventHandler(ArticleClick);
                Centr_panel.Controls.Add(label1);


                    PictureBox image1 = new PictureBox();
                    image1.Location = new Point(0, articleY + 25);
                    image1.Tag = label1.Text;
                    image1.Size = new Size(Centr_panel.Width, 150);
                    image1.Click += new System.EventHandler(clik_na_pic);
                    image1.SizeMode = PictureBoxSizeMode.StretchImage;
                    try
                    {

                        image1.LoadAsync(rdr[1].ToString());
                      //  image1.Image.Save("picccc.Bmp", ImageFormat.Bmp);
                    }
                    catch(Exception)
                    {
                        image1.Image = new Bitmap("defolt_statiy.jpg");
                    }

                  //  image1.LoadAsync(rdr[1].ToString());
                    
                    Centr_panel.Controls.Add(image1);
                
                piccc.Add(image1);
                arts.Add(label1);
                articleY += 180;
            }
            rdr.Close();


            reclama.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama.LoadAsync(advertising_stract.random());


            reclama2.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama2.LoadAsync(advertising_stract.random());


            reclama3.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama3.LoadAsync(advertising_stract.random());
            
           
        }    

        private void butto_search_Click(object sender, EventArgs e)
        {
            Centr_panel.Controls.Clear();
            Centr_panel.Controls.Add(popularArticlesLabel);

            textBox_login.Text = "";
            textBox_password.Text = "";
            
            MySqlCommand cmd = new MySqlCommand("SELECT Header, Picture FROM " + Tables.ARTICLES +
                " WHERE header like '%" + textBox_search.Text + "%'" +
                " OR category like '%" + textBox_search.Text + "%'" +
                " OR author like '%" + textBox_search.Text + "%' LIMIT 0, 3", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            int articleY = 50;
            while (rdr.Read())
            {
                LinkLabel label1 = new LinkLabel();
                label1.Location = new Point(0, articleY);
                label1.Size = new Size(Centr_panel.Width, 20);
                label1.Text = rdr[0].ToString();
                label1.Click += new System.EventHandler(ArticleClick);
                Centr_panel.Controls.Add(label1);

                
                PictureBox image1 = new PictureBox();
                image1.Location = new Point(0, articleY + 25);
                image1.Size = new Size(Centr_panel.Width, 150);
                image1.Click += new System.EventHandler(clik_na_pic);
                image1.SizeMode = PictureBoxSizeMode.StretchImage;

                try
                {
                    image1.LoadAsync(rdr[1].ToString());
                }
                catch (Exception)
                {
                    image1.Image = new Bitmap("defolt_statiy.jpg");
                }
                    
                //image1.Click += new System.EventHandler(ArticleClick);
                Centr_panel.Controls.Add(image1);

                piccc.Add(image1);
                arts.Add(label1);
                articleY += 180;
            }
            rdr.Close();
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
            // TODO: dddd
            bool author = false;

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM `Authors` WHERE UserName = '" + textBox_login.Text + "'", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            if (rdr[0].ToString() != "0")
            {
                author = true;
            }
            rdr.Close();

            if (author)
            {
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
    }
}