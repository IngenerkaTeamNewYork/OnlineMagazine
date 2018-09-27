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
    public partial class To_come_in : Form
    {
        public To_come_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkBox_admin.Checked)
            {
                //Form ifr = Application.OpenForms[0];
                //ifr.Show();
                // GhostMainForm link_of_come.Visible = false;
            }
            else
            {

                Form ifrm = new AdminMainForm();
                ifrm.Show(); // отображаем Form2
                ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                this.Close();// скрываем Form1 (this - текущая форма)
                Form prichem = Application.OpenForms[0];
                prichem.Hide();
            }
        }
    }
}
