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
    public partial class GhostMainForm : Form
    {
        public static List<AuthorStat> stat = new List<AuthorStat>();

        public GhostMainForm()
        {
            InitializeComponent();



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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
        {
            statiya stat = new statiya();
            stat.name_statiya = "Котята и вода";
            stat.text_statii = "Я топлю котят(Хой!)";
            stat.kategorita_statii = "Животные";
            stat.kartinki_statii = new List<Image>();
            Image1.Image = Image.FromFile("cat.jpg");
            //stat.kartinki_statii.Add(Image("cat.jpg"));

            label_of_like.Text = stat.name_statiya;
            label5.Text = stat.text_statii;
            label_of_name.Text = stat.kategorita_statii;
            
            
            StatiyaForm1 OknoStatiya = new StatiyaForm1(label_of_like.Text, label_of_name.Text, label5.Text);
            OknoStatiya.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration form = new Registration();
            form.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            To_come_in form = new To_come_in();
            form.ShowDialog();
        }

        private void label_author_Click(object sender, EventArgs e)
        {
            StastisticsForm form1 = new StastisticsForm(stat[0]);
            form1.ShowDialog();
        }

        private void categories_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoriesForm form3 =new CategoriesForm();
            form3.ShowDialog();
        }
    }
}