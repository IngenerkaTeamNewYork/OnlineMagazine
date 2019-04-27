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
    public partial class DetailsForm : Form
    {
        public DetailsForm(ArticleDetailsUserControl Details)
        {
            InitializeComponent();
            this.Controls.Add(Details);
            this.Controls.AddRange(UCFunctions.ReadFromDB(this.Name).ToArray());
        }

        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
