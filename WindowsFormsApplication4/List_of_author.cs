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
            foreach (LinkLabel n in loginy_avtorov)
            {
                if (sender.Equals(n))
                {
                    Information_o_avtore gg = new Information_o_avtore(n.Text, pic[s], Information[s]);
                    gg.ShowDialog();
                }
                s++;
            }
            s = 0;
        }

        public static List<AuthorStat> stat = new List<AuthorStat>();
        public int s = 0;
        public static List<LinkLabel> loginy_avtorov = new List<LinkLabel>();
        public List<string> pic = new List<string>();
        public List<string> Information = new List<string>();

        public int uy = 0;
        public List_of_author(List<AuthorStat> writers)
        {
            InitializeComponent();

            MySqlCommand cmd = new MySqlCommand("SELECT UserName, Pic, Information_about_author FROM `Authors`", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

           
            while (rdr.Read())
            {
                LinkLabel linklabel1 = new LinkLabel();
                linklabel1.Size = new Size(70, 20);
                linklabel1.Location = new Point(50, 10 + 30 * uy);
                linklabel1.Text = rdr[0].ToString();
                string p;
                p = rdr[1].ToString();
                pic.Add(p);
                string inf;
                inf = rdr[2].ToString();
                Information.Add(inf);
                linklabel1.Click += new System.EventHandler(Click_na_link);
                panel1.Controls.Add(linklabel1);
                loginy_avtorov.Add(linklabel1);
                uy++;
            }

            rdr.Close();
        }

        private void List_of_author_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StastisticsForm form1 = new StastisticsForm("");
            form1.ShowDialog();
        }
    }
}