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
    public partial class FBIform : Form
    {
        public FBIform()
        {
            InitializeComponent();
        }

        private void FBIform_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;
        }

        private void FBIform_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
