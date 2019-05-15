using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace OnlineMag
{
    public partial class NewPages : Form
    {
        public struct newPage
        {
            public String Header;
            public Label Label_;
            public CheckBox CheckBox_;
        }

        public List<newPage> ListOfPages = new List<newPage>();
        string text;

        public NewPages()
        {
            InitializeComponent();
        }

        void LoadPages()
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;
            this.Controls.Clear();
            this.Controls.Add(new Label() 
            { 
                Text = "Новый",
                Location = new Point(0,0),
                Size = new Size(50, 20)
            });
            this.Controls.Add(new Label()
            {
                Text = "Название",
                Location = new Point(100, 0)
            });

            List<String> articlesList = SQLClass.Select("SELECT header, new FROM " + Tables.ARTICLES);

            int PosY = 20;
            for (int artIndex = 0; artIndex < articlesList.Count; artIndex += 2)
            {
                newPage Page = new newPage();
                Page.Header = articlesList[artIndex];

                Page.CheckBox_ = new CheckBox();
                Page.CheckBox_.Location = new Point(10, PosY);
                Page.CheckBox_.Size = new Size(50, 30);
                Page.CheckBox_.Click += new System.EventHandler(cbnewpage);
                Page.CheckBox_.Checked = (articlesList[artIndex + 1] == "1");


                Page.Label_ = new Label();
                Page.Label_.Location = new Point(100, PosY);
                Page.Label_.Size = new Size(250, 30);
                Page.Label_.Text = articlesList[artIndex];

                Page.Label_.Click += new System.EventHandler(Label_Click);
                if (articlesList[artIndex + 1] == "0")
                {
                    Page.Label_.ForeColor = Color.Gray;
                }

                ListOfPages.Add(Page);
                this.Controls.Add(Page.CheckBox_);
                this.Controls.Add(Page.Label_);
                PosY += 30;
            }
            
        }

        void cbnewpage(object sender, EventArgs e)
        {
            foreach (newPage a in ListOfPages)
            {
                if (sender.Equals(a.CheckBox_))
                {
                    if (a.Label_.ForeColor == Color.Gray)
                    {
                        SQLClass.Update("UPDATE " + Tables.ARTICLES +
                            " SET `new`= 1 WHERE header = '" + a.Header + "'");
                    }
                    else
                    {
                        SQLClass.Update("UPDATE " + Tables.ARTICLES +
                            " SET `new`= 0 WHERE header = '" + a.Header + "'");
                    }
                }
            }
            LoadPages();
        }

        void NewPages_Load(object sender, EventArgs e)
        {
            LoadPages();
        }            
        void Label_Click(object sender, EventArgs e)
        {
           /* foreach (newPage Label_ in ListOfPages)
            {*/

                Statiya stat = Statiya.GetStatiyaFromArticleName(((Label)sender).Text);
                StatiyaForm form = new StatiyaForm(stat);
                form.ShowDialog();
                
           // }
            

        }
    }
}
