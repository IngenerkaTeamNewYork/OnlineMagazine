using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class StatiyaForm : Form
    {
        bool avtor = false;
        bool isLike = false;
        bool isDisLike = false;
        
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
        
        public StatiyaForm(statiya stat, bool YaAvtor = false)
        {
            InitializeComponent();

            avtor = YaAvtor;

            Kategoriatext.Enabled = avtor;
            Stattext.Enabled = avtor;
            
            Maintext.Text = stat.name_statiya;
            Kategoriatext.Text = stat.kategorita_statii;
            Stattext.Text = stat.text_statii;

            Kategoriatext.Font = Configs.ZAGOLOVOK_FONT;

            Authortext.Font = Configs.ZAGOLOVOK_FONT;

            GetStata(labelLike, labeldis, Maintext.Text);

            try
            {
                pictureBox1.LoadAsync(stat.picture);
            }
            catch(Exception)
            {
                pictureBox1.Image = new Bitmap("defolt_statiy.jpg");
            }
            Authortext.Text = stat.name_author;

            pictureBoxLike.Image = Properties.Resources.like;
            pictureBoxDislike.Image = Properties.Resources.Dislike;

           
        }
        
        private void pictureBoxLike_Click(object sender, EventArgs e)
        {
            isLike = !isLike;               
            pictureBoxLike.Image = (isLike) ? 
                Properties.Resources.Like2 : 
                Properties.Resources.like;
                        
            List<String> likes = SQLClass.Select("SELECT Article FROM " + Tables.LIKES + " WHERE Article = '" + Maintext.Text + "'");            
            if (isLike)
            {
                if (likes.Count > 0 )
                {
                    SQLClass.Update("UPDATE " + Tables.LIKES + 
                        " SET LikesCount = LikesCount + 1" +
                        " WHERE Article = '" + Maintext.Text + "'");
                }
                else
                {
                    SQLClass.Insert(
                        "INSERT INTO " + Tables.LIKES + 
                        "(Article, Author, Category, LikesCount, DisCount)" +
                        " VALUES (" +
                        "'" + Maintext.Text + "'" +
                        ", '" + Authortext.Text + "'" +
                        ", '" + Kategoriatext.Text + "'" +
                        ",1" +
                        ",0)");
                }        
            }
            else
            {
                SQLClass.Update("UPDATE " + Tables.LIKES +
                    " SET LikesCount = LikesCount - 1" +
                    " WHERE Article = '" + Maintext.Text + "'");
            }

            GetStata(labelLike, labeldis, Maintext.Text);
        }
        
        private void pictureBoxDislike_Click(object sender, EventArgs e)
        {
            isDisLike = !isDisLike;
            pictureBoxDislike.Image = (isDisLike) ?
                Properties.Resources.DisLike2 :
                Properties.Resources.Dislike;

            List<String> dislikes = SQLClass.Select("SELECT Article FROM " + Tables.LIKES + " WHERE Article = '" + Maintext.Text + "'");
         
            if (isDisLike)
            {
                if (dislikes.Count > 0 )
                {
                    SQLClass.Update("UPDATE " + Tables.LIKES +
                        " SET DisCount = DisCount + 1" +
                        " WHERE Article = '" + Maintext.Text + "'");
                }
                else
                {
                    SQLClass.Insert(
                        "INSERT INTO " + Tables.LIKES +
                        "(Article, Author, Category, LikesCount, DisCount)" +
                        " VALUES (" +
                        "'" + Maintext.Text + "'" +
                        ", '" + Authortext.Text + "'" +
                        ", '" + Kategoriatext.Text + "'" +
                        ",0" +
                        ",1)");
                }
            }
            else
            {
                SQLClass.Update("UPDATE " + Tables.LIKES +
                    " SET DisCount = DisCount - 1" +
                    " WHERE Article = '" + Maintext.Text + "'");
            }

            GetStata(labelLike, labeldis, Maintext.Text);
        }

        private void StatiyaForm1_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;

            List<string> s = Advertising.GetRandom();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.LoadAsync(s[0]);
            pictureBox2.Tag = s[1];

            s = Advertising.GetRandom();
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.LoadAsync(s[0]);
            pictureBox3.Tag = s[1];


            List<String> countRecords = SQLClass.Select(
                "SELECT COUNT(*) FROM " + Tables.READ_OF_ARTICLES + 
                " WHERE `name_of_article` = '" + Maintext.Text + "'");
            label1.Text = "Просмотров: " + countRecords[0];


            SQLClass.Insert(
                "INSERT INTO " + Tables.READ_OF_ARTICLES +
                "(name_of_article, reader, dt)" +
                "VALUES (" +
                "'" + Maintext.Text + "'" +
                ", '" + Users.CURRENT_USER + "'" +
                ", DATE_FORMAT(NOW(), '%Y-%m-%d'))");

            #region Деньги за показанную рекламу
            int money = 2;

            List<String> AuthorExist = SQLClass.Select("SELECT COUNT(*) FROM " + Tables.BALANCE + 
                " WHERE AUTHOR = '" + Authortext.Text + "'");

            if (AuthorExist[0] != "0")
            {
                SQLClass.Update(" UPDATE " + Tables.BALANCE +
                    " SET Summa = Summa + " + money.ToString() +
                    " WHERE Author = '" + Authortext.Text + "'");
            }
            else
            {
               SQLClass.Insert(
                    "INSERT INTO " + Tables.BALANCE +
                    " (Summa, Author)" +
                    " VALUES (" +
                    money.ToString() + ", " +
                    "'" + Authortext.Text + "')");
            }
            #endregion
        }

        private void likesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void redact_Click(object sender, EventArgs e)
        {
          
        }
    }
}