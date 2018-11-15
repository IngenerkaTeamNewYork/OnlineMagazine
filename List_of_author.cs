using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class List_of_author : Form
    {
        public void Click_na_link(object sender, EventArgs e)
        {
            int s = 0;
            foreach (LinkLabel n in loginy_avtorov)
            {
                if (sender.Equals(n))
                {
                    Information_o_avtore.getAuthorInfo(n.Text, pic[s], Information[s], panel2);
                    
                }
                s++;
            }
            s = 0;
        }

        public static List<AuthorStat> stat = new List<AuthorStat>();
        public static List<LinkLabel> loginy_avtorov = new List<LinkLabel>();
        public static List<string> pic = new List<string>();
        public static List<string> Information = new List<string>();


        public void sdfsdf(Panel panel1)
        {            
            int uy = 0;
            List<String> Auths = SQLClass.Select("SELECT UserName, Pic, Information_about_author FROM " + Tables.AUTHORS);

            for (int index = 0; index < Auths.Count; index += 3)
            {
                LinkLabel linklabel1 = new LinkLabel();
                linklabel1.Size = new Size(70, 20);
                linklabel1.Location = new Point(50, 10 + 30 * uy);
                linklabel1.Text = Auths[index].ToString();
                linklabel1.Click += new System.EventHandler(Click_na_link);

                pic.Add(Auths[index + 1].ToString());
                Information.Add(Auths[index + 2].ToString());

                panel1.Controls.Add(linklabel1);
                loginy_avtorov.Add(linklabel1);
                uy++;
            }

        }

        public List_of_author()
        {
            InitializeComponent();
            sdfsdf(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StastisticsForm form1 = new StastisticsForm("");
            form1.ShowDialog();
        }

        private void List_of_author_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}