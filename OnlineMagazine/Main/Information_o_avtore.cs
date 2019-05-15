using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace OnlineMag
{
    public partial class Information_o_avtore : Form
    {
        public string name_avtor;
        public string pic_avtor;
        public string infa_ob_avtore;
        public Information_o_avtore(string name, string pic, string infa)
        {
            InitializeComponent();
            name_avtor = name;
            pic_avtor = pic;
            infa_ob_avtore = infa;
        }
        public static void Label3_Click(object sender, EventArgs e)
        {
            Statiya stat = Statiya.GetStatiyaFromArticleName(((Label)sender).Text);
            StatiyaForm form = new StatiyaForm(stat);
            form.ShowDialog();
        }
        public static void getAuthorInfo(string name_avtor, string pic_avtor, string infa_ob_avtore, Panel panel1)
        {
            panel1.Controls.Clear();
            Label label1 = new Label();
            label1.Size = new Size(300, 30);
            label1.Location = new Point(50, 15);
            label1.Font = Configs.ZAGOLOVOK_FONT;
            label1.Text = "Информация о " + name_avtor;
            panel1.Controls.Add(label1);

            Label label2 = new Label();
            label2.Size = new Size(200, 13);
            label2.Location = new Point(50, 50);
            panel1.Controls.Add(label2);

            Label label4 = new Label();
            label4.Size = new Size(200, 13);
            label4.Location = new Point(300, 0);
            label4.Text = "Статьи, которые он написал";
            panel1.Controls.Add(label4);

            List<String> Stat = SQLClass.Select("SELECT DISTINCT Header FROM " + Tables.ARTICLES + 
                " WHERE Author = '" + name_avtor + "'");

            for (int index = 0; index < Stat.Count; index ++)
            {
                Label label3 = new Label();
                label3.Size = new Size(500, 13);
                label3.Location = new Point(300, 50 * (index + 1));
                label3.Text = Stat[index];
                panel1.Controls.Add(label3);
                label3.Click += new System.EventHandler(Label3_Click);
            }

            PictureBox pictureBox1 = new PictureBox();

            pictureBox1.Size = new Size(225, 199);
            pictureBox1.Location = new Point(70, 76);
            panel1.Controls.Add(pictureBox1);

            String[] chasti_stroki = pic_avtor.Split(new char[] { ' ', '/' });
            WebClient client = new WebClient();

            try
            {
                pictureBox1.Image = new Bitmap(chasti_stroki[chasti_stroki.Length - 1]);

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                try
                {
                    pictureBox1.Load(pic_avtor);
                    Uri uri = new Uri(pic_avtor);

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    client.DownloadFileAsync(uri, chasti_stroki[chasti_stroki.Length - 1]);
                }
                catch (Exception)
                {
                    pictureBox1.Image = new Bitmap("defolt_avtor.jpg");

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = infa_ob_avtore;
        }
        public void Information_o_avtore_Load(string author)
        {
            label1.Text = "Информация о " + name_avtor;
            label4.Text = "Статьи, которые он прочитал";

            String[] chasti_stroki = pic_avtor.Split(new char[] { ' ', '/' });
            WebClient client = new WebClient();
            Uri uri = new Uri(pic_avtor);

            try
            {
                pictureBox1.Image = new Bitmap(chasti_stroki[chasti_stroki.Length - 1]);
            }
            catch (Exception)
            {
                try
                {
                    pictureBox1.Load(pic_avtor);
                 
                    
                    client.DownloadFileAsync(uri, chasti_stroki[chasti_stroki.Length - 1]);
                   
                    //pictureBox1.Image.Save(chasti_stroki[chasti_stroki.Length - 1]);
                }
                catch (Exception)
                {
                    pictureBox1.Image = new Bitmap("defolt_avtor.jpg");
                }
            }            

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = infa_ob_avtore;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Information_o_avtore_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;
        }

        
    }
}
