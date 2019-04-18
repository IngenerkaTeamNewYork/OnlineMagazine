﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class UserControlMainAuthor : UserControl
    {
        public List<string> par;
        bool fu = false;

        public DragAndDrop Drag = new DragAndDrop();

        public UserControlMainAuthor(List<string> parametries)
        {
            InitializeComponent();
            Init(parametries);
        }

        public void Init(List<string> param)
        {
            Drag.AddDNDFunctions(this);
            Menus.AddDeleteMenu(this);

            par = param;
            if (param.Count == 0)
            {
                throw new Exception("Нету параметров");
            }


            List<string> author = SQLClass.Select("SELECT UserName, `Likes`, `Dislikes`, " +
                "`Information_about_author`, `Pic` FROM `Authors` WHERE UserName = '" + param[0] + "'");
            if (author.Count == 0)
            {
                author = SQLClass.Select("SELECT UserName, `Likes`, `Dislikes`, " +
                "`Information_about_author`, `Pic` FROM `Authors` WHERE UserName = 'жуков'");
            }

            if (author.Count > 3)
            {
                label1.Text = author[0];
                label3.Text = author[1];
                label5.Text = author[2];
                label6.Text = author[3];
            }


            PictureBox b = new PictureBox();
            try
            {
                b.Load(author[4]);
            }
            catch
            {
                b.Image = null;
            }

            pictureBox1.Image = b.Image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            statia();
        }

        /// <summary>
        /// Добавление UserControl с детальной инфой об авторе
        /// </summary>
        public static void AddNewBlock(object sender, EventArgs e)
        {

            Control c = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            UCParameters p = new UCParameters("block.UserControlMainAuthor", new List<string>() { "ПрПрПр" });
            p.ShowDialog();
            p.ParamsList.Add("Жуков");
            UserControlMainAuthor a1 = new UserControlMainAuthor(p.ParamsList);
            string shsvfhksv = "";
            foreach (string asd in p.ParamsList)
            {
                shsvfhksv += asd + ',';
            }
            Menus.InsertBlockToDB(sender, a1, shsvfhksv);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        public void statia()
        {
            List<string> stat = SQLClass.Select("SELECT Header FROM Articles1 WHERE Author = '" + label1.Text + "' LIMIT 5");
            for (int i = 0; i < stat.Count; i++)
            {
                Label labelstat = new Label();
                labelstat.Location = new Point(172, 110 + i * 20);
                labelstat.Size = new Size(150, 20);
                labelstat.Text = stat[i].ToString();
                this.Controls.Add(labelstat);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
