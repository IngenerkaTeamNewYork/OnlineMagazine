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
    public partial class To_come_in : Form
    {
        public To_come_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkBox_admin.Checked)
            {
                GhostMainForm form = new GhostMainForm();
                form.ShowDialog();
               // GhostMainForm link_of_come.Visible = false;
            }
            else
            {
                AdminMainForm form = new AdminMainForm();
                form.ShowDialog();
            }
        }
    }
}
