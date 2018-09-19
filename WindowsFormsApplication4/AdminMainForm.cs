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
            Form AddPromoForm = new Form();
            AddPromoForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GhostMainForm form = new GhostMainForm();
            form.ShowDialog();
        }
    }
}
