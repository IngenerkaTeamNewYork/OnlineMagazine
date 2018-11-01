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
    public partial class Добавить_картинку : Form
    {
        public Добавить_картинку()
        {
            InitializeComponent();
        }
        private void dobavit_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                kartinka.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void otmena_Click(object sender, EventArgs e)
        {
            kartinka.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_vvod_texta.Text = string.Empty;
        }
    }
}
