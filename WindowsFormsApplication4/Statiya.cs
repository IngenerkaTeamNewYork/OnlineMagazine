using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public struct statiya
    {
        public String  name_statiya;
        public List<Image> kartinki_statii;
        public String kategorita_statii;
        public String text_statii;

        public void ShowText()
        {
            MessageBox.Show("1");
        }
    }
}
