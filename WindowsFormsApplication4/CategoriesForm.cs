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
    public partial class CategoriesForm : Form
    {
        public static List<String> CategoriesList = new List<string>(new string[] { });
        public string text;
        public CategoriesForm()
        {
            InitializeComponent();
            int ind = 0;
            foreach (String cat in CategoriesList)
            {
                for (int i = 0; i > 0; i++)
                {
                    Label label = new Label();
                    label.Size = new Size(70, 80);
                    label.Location = new Point(50, 10 + 30 * ind);
                    label.Text = CategoriesList[i];
                    this.Controls.Add(label);
                }
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_name.Visible = true;
            CategoriesList.Add(textBox_name.Text);
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
