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
            pictureBox1.Image = stat.kartinki_statii;
            Authortext.Text = stat.name_author;
            pictureBox1.Load(stat.picture);
        }

        private void StatiyaForm1_Load(object sender, EventArgs e)
        {

        }        
    }
}