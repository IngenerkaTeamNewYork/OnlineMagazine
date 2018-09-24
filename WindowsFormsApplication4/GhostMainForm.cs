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
        public GhostMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void articleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
        {

            Image1.Image = Image.FromFile("cat.jpg");
            label_of_like.Text = "Котята и вода";
            articleTextBox.Text = "Я топлю котят(Хой!)" +
                Environment.NewLine + "Колхозный панк" +
                Environment.NewLine + "Панки - хой!";
            label_of_name.Text = "Животные";
         

            
            statiya stat = new statiya();
            stat.name_statiya = label_of_like.Text;
            stat.text_statii = articleTextBox.Text;
            stat.kategorita_statii = label_of_name.Text;
            stat.kartinki_statii = new List<Image>();
            stat.kartinki_statii.Add(Image1.Image);


            StatiyaForm1 OknoStatiya = new StatiyaForm1(stat);
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


    }
}