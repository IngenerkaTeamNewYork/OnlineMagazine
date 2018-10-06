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
    public partial class List_of_author : Form
    {
        public static List<AuthorStat> stat = new List<AuthorStat>();

        public List_of_author(List<AuthorStat> writers)
        {
            InitializeComponent();
            int uy = 0;
            foreach(AuthorStat write in writers)
            {
                LinkLabel linklabel1 = new LinkLabel();
                linklabel1.Size = new Size (70, 20); 
                linklabel1.Location = new Point (50, 10 + 30*uy);
                linklabel1.Text = write.name;

                panel1.Controls.Add(linklabel1);
                uy++;
            }

        }

        private void List_of_author_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StastisticsForm form1 = new StastisticsForm(stat[0]);
            form1.ShowDialog();
        }
    }
}
