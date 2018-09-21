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
        public CategoriesForm()
        {
            InitializeComponent();
        }

        public static List<String> CategoriesList = new List<string>(new string [] { });
        public string text;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_name.Visible = true;
            Label newlabel = new Label();
            newlabel.Top = 400;
            newlabel.Text = textBox_name.Text;
            this.Controls.Add(newlabel);

            CategoriesList.Add(text);
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
