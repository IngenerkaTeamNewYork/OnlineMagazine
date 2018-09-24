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
    public partial class Spisok_reklamy : Form
    {
        public Spisok_reklamy(List<Reklama> mnogo_reklamy)
        {
            InitializeComponent();

            if (mnogo_reklamy.Count > 0)
            {
                label2.Text = mnogo_reklamy[0].text;
            }
            if (mnogo_reklamy.Count > 1)
            {
                label1.Text = mnogo_reklamy[1].text;
            }

            if (mnogo_reklamy[0].dateFrom <= DateTime.Now)
            {
                button2.Visible = false;
            }
            if (mnogo_reklamy[1].dateFrom <= DateTime.Now)
            {
                button3.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Spisok_reklamy_Load(object sender, EventArgs e)
        {

        }
    }
}
