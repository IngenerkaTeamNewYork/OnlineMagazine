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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Spisok_reklamy sps = new Spisok_reklamy();
            sps.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Spisok_reklamy d = new Spisok_reklamy();
            d.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GhostMainForm dd = new GhostMainForm();
            dd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            New_stati fgf = new New_stati();
            fgf.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CategoriesForm form = new CategoriesForm();
            form.ShowDialog();
        }

        private void button_author_Click(object sender, EventArgs e)
        {
            FBIform form = new FBIform();
            form.ShowDialog();
        }

        private void button_statistika_Click(object sender, EventArgs e)
        {
            StastisticsForm form1 = new StastisticsForm(GhostMainForm.stat[0]);
            form1.ShowDialog();
        }
    }
}
