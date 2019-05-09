using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMag
{
    public partial class DesignForm : Form
    {
        public DesignForm()
        {
            InitializeComponent();
        }

        private void ИзменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label pb = (Label)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            LabelUniqueForm f = new LabelUniqueForm(pb);
            f.ShowDialog();
            pb = f.newLabel;
            LabelUniqueForm.UpdateLabelDesignInDb(pb);
        }
    }
}
