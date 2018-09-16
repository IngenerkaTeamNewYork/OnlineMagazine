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

        private void image_Click(object sender, EventArgs e)
        {
            statiya stat = new statiya();
            stat.name_statiya = "Котята и вода";
            stat.text_statii = "Я топлю котят(Хой!)";
            stat.kategorita_statii = "Животные";
            stat.kartinki_statii = new List<Image>();
            //Image img = Image.
            //stat.kartinki_statii.Add(Image("cat.jpg"));

            label4.Text = stat.name_statiya;
            label5.Text = stat.text_statii;
            label6.Text = stat.kategorita_statii;

        }
    }
}
