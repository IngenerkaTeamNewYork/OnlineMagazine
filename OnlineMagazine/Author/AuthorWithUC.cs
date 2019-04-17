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
    public partial class AuthorWithUC : Form
    {
        public string AuthorName;
        public AuthorWithUC(string AuthorName)
        {
            InitializeComponent();
            this.AuthorName = AuthorName;
            this.Controls.Add(new UserControlMainAuthor(new List<string>() { AuthorName })
            {
                Location = new Point(200, 0)
            });
            this.Controls.Add(new AuthenticationUserControl(new List<string>()));
        }
    }
}
