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
    public partial class Information_o_avtore : Form
    {
        public string name_avtor;
        public Information_o_avtore(string name)
        {
            InitializeComponent();
            name_avtor = name;
        }

        private void Information_o_avtore_Load(object sender, EventArgs e)
        {
            label1.Text = "Инвормация о " + name_avtor;
        }
    }
}
