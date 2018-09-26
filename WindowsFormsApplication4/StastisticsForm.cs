using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{

    public partial class StastisticsForm : Form
    {

        public StastisticsForm(AuthorStat stata)
        {
            InitializeComponent();



        }

        private void StastisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void list_of_author_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewsCount.Text = List_of_author.stat[list_of_author.SelectedIndex].Views.ToString();
            LikesCount.Text = List_of_author.stat[list_of_author.SelectedIndex].Likes.ToString();
            DisLikesCount.Text = List_of_author.stat[list_of_author.SelectedIndex].DisLikes.ToString();
            name.Text = List_of_author.stat[list_of_author.SelectedIndex].name.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }



       
    }
}
