﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class ArticleDetailsUserControl : UserControl
    {
        public DragAndDrop Drag = new DragAndDrop();

        public List<string> ListOfArticles;
        public ArticleDetailsUserControl(List<string> Articles)
        {
            InitializeComponent();
            Menus.AddDeleteMenu(this);
            Drag.AddDNDFunctions(this);

            ListOfArticles = Articles;

            int x = 356;
            int y = 376;

            try
            {
                x = Convert.ToInt32(Articles[1]);
                y = Convert.ToInt32(Articles[2]);
            } catch (ArgumentOutOfRangeException)
            {
                // Используем тандартный размер
            }


            this.Size = new Size(x, y);

            List<string> result = SQLClass.Select("SELECT Author, Category, Text, Picture FROM " + "Articles1" + " WHERE `Header` = '" + Articles[0] + "'");

            if (result.Count > 3)
            {
                AuthorsNameLabel.Text = result[0];
                ArticleLabel.Text = Articles[0];
                ArticleTextLabel.Text = result[2];
            } 
            
            try
            {
                ArticlePicture.Load(result[3]);
            }
            catch
            {
                ArticlePicture.Image = null;
            }
        }

        /// <summary>
        /// Добавление UserControl с детальной инфой о статье
        /// </summary>
        public static void AddNewBlock(object sender, EventArgs e)
        {
            Control c = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            UCParameters p = new UCParameters("block.ArticleDetailsUserControl", new List<string>());
            p.ParamsList.Add("Война и мир");
            p.ShowDialog();
            ArticleDetailsUserControl a1 = new ArticleDetailsUserControl(p.ParamsList);
            string Buff = "";
            foreach (string Param in p.ParamsList)
            {
                Buff += Param + ',';
            }
            Menus.InsertBlockToDB(sender, a1, Buff);
        }

        private void ArticleDetailsUserControl_Load(object sender, EventArgs e)
        {
            /*if (Program.ShowColor == true)
            {
                this.BackColor = SystemColors.ActiveBorder;

            }*/
        }

        private void ArticleTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void ArticleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
