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
    public partial class Designer : Form
    {
        public Designer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null)
            {
                this.Close();
            }
            else 
            {
                try 
                {
                    Configs.KOL_VO_ELEMENTOV = Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Вводи число!");
                }
            }
        }
    }
}
