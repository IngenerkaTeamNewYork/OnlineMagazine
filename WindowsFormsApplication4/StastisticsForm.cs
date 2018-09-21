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
    public partial class StastisticsForm : Form
    {
        public StastisticsForm(int Views, int Likes, int DisLikes, int PageAmount=-1)
        {
            InitializeComponent();

            ViewsCount.Text = Views.ToString();
            LikesCount.Text = Likes.ToString();
            DisLikesCount.Text = DisLikes.ToString();
        }
    }
}
