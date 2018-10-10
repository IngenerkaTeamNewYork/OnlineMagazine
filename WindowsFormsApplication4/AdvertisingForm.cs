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
    public partial class AdvertisingForm : Form
    {
        public AdvertisingForm()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.ShowDialog();
        }

        private void AdvertisingForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_agree2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
