using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMag
{
    public partial class PodborkiUserControl : UserControl
    {
        //public DragAndDrop Drag = new DragAndDrop();
        public static string search;
        public DragAndDrop Drag = new DragAndDrop();
        public PodborkiUserControl()
        {
            InitializeComponent();
        }

        private void PodborkiUserControl_Load(object sender, EventArgs e)
        {
            Drag.AddDNDFunctions(this);
            List<String> collList = SQLClass.Select("SELECT DISTINCT Coll_text FROM " + Tables.COLLECTION +
                " LIMIT 0, " + Configs.KOL_VO_ELEMENTOV_Podborka);
            int collY = 25;
            for (int colIndex = 0; colIndex < collList.Count; colIndex++)
            {
                Label collLabel = new Label();
                collLabel.Location = new Point(0, collY);
                collLabel.Size = new Size(100, 20);
                collLabel.Text = collList[colIndex].ToString();
                collLabel.Click += new EventHandler(podClick);
                this.Controls.Add(collLabel);
                collY += 28;
            }
        }

        public void podClick(object sender, EventArgs e)
        {
            search = ((Label)sender).Text;
            GhostMainForm.dddd = true;
            //GhostMainForm.Search_Click(sender, e);
        }
    }
}
