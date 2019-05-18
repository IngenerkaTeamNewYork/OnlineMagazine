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
            Program.LabelControlCMS = LabelContextMenuStrip1;
        }

        private void ИзменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch(((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl.GetType().Name)
            {
                    case "label":
                    Label pb = (Label)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
                    LabelUniqueForm f = new LabelUniqueForm(pb);
                    f.ShowDialog();
                    pb = f.newLabel;
                    LabelUniqueForm.UpdateLabelDesignInDb(pb);
                    break;
                case "Button":
                    Button pb1 = (Button)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
                    ButtonUniqueForm f1 = new ButtonUniqueForm(pb1);
                    f1.ShowDialog();
                    pb1 = f1.newButton;
                    LabelUniqueForm.UpdateLabelDesignInDb(pb1);
                    break;
            }
        }

        private void LabelContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void DesignForm_Load(object sender, EventArgs e)
        {

        }
    }
}
