using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class StatiyaForm1 : Form
    {
        bool isLike = false;
        bool isDisLike = false;
        
        public StatiyaForm1(statiya stat)
        {
            InitializeComponent();

            Maintext.Text = stat.name_statiya;
            Kategoriatext.Text = stat.kategorita_statii;
            Stattext.Text = stat.text_statii;
            try
            {
                pictureBox1.Load(stat.picture);
            }
            catch(Exception)
            {
                pictureBox1.Image = new Bitmap("defolt_statiy.jpg");
            }
            Authortext.Text = stat.name_author;

            pictureBoxLike.Image = Properties.Resources.like;
            pictureBoxDislike.Image = Properties.Resources.Dislike;
        }

        private void StatiyaForm1_Load(object sender, EventArgs e)
        {

        }

        private void Stattext_TextChanged(object sender, EventArgs e)
        {

        }

        private void artTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void pictureBoxLike_Click(object sender, EventArgs e)
        {
            pictureBoxLike.Image = (isLike) ? Properties.Resources.like : Properties.Resources.Like2;
            isLike = !isLike;

            if (isLike)
            {
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO Likes(Article, Author, Category, LikesCount, DisCount)" +
                    " VALUES (" +
                    "'" + Maintext.Text + "'" +
                    ", '" + Authortext.Text + "'" +
                    ", '"+ Kategoriatext.Text + "'"+
                    ",1, 3)", SQLClass.CONN);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxDislike_Click(object sender, EventArgs e)
        {
            if(isDisLike)
            {
                isDisLike = false;
                pictureBoxDislike.Image = Properties.Resources.Dislike;
            }
            else
            {
                isDisLike = true;
                pictureBoxDislike.Image = Properties.Resources.DisLike2;
            }

            if (isDisLike)
            {
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO Likes(Article, Author, Category, LikesCount, DisCount)" +
                    " VALUES (" +
                    "'" + Maintext.Text + "'" +
                    ", '" + Authortext.Text + "'" +
                    ", '" + Kategoriatext.Text + "'" +
                    ",1, 3)", SQLClass.CONN);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                //Ñîçäàòü îòäåëüíûé ñòîëáèê äèçëàéêîâ â MySQL 
            }
        }
     }
}