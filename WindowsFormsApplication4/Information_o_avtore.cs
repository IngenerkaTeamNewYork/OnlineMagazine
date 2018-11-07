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

namespace WindowsFormsApplication4
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

        private void Information_o_avtore_Load(object sender, EventArgs e)
        {
            label1.Text = "Инвормация о " + name_avtor;

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
                    pictureBox1.Image = new Bitmap("defolt_statiy.jpg");
                }
            }
            /*
            try
            {
                pictureBox1.Load(pic_avtor);
            }
            catch(Exception)
            {
                pictureBox1.Image = new Bitmap("defolt_avtor.jpg");
            }
             */
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = infa_ob_avtore;
        }
    }
}
