using System;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class StatiyaForm1 : Form
    {
        public StatiyaForm1(statiya stat)
        {
            InitializeComponent();

            Maintext.Text = stat.name_statiya;
            Kategoriatext.Text = stat.kategorita_statii;
            Stattext.Text = stat.text_statii;
            if (stat.picture != null)
            {
                pictureBox1.Load(stat.picture);
            }
            else stat.kartinki_statii = null;
            
            Authortext.Text = stat.name_author;
        }

        private void StatiyaForm1_Load(object sender, EventArgs e)
        {

        }        
    }
}