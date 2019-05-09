using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data;
using MySql.Data.MySqlClient;

namespace OnlineMag
{
    public partial class CategoriesUserControl : UserControl
    {
        public List<string> asd;
        public DragAndDrop Drag = new DragAndDrop();
        public static Label label = new Label();

        public static LinkLabel l1 = new LinkLabel();

        /// <summary>
        /// Конструктор который заполняет <see cref="tableLayoutPanel1"/> 
        /// </summary>
        /// <param name="Categories">
        /// Список категорий для отображения на <see cref="tableLayoutPanel1"/>,
        /// Если равен null или не указан, берутся все категории из базы
        /// </param>
        /// <param name="AmountOfCategories">
        /// Лимит на количество категорий для загрузки из базы. 
        /// </param>
        public CategoriesUserControl(List<string> CategoriesParams)
        {
            InitializeComponent();

            label_cats_header.Font = Configs.ZAGOLOVOK_FONT;
            Menus.AddDeleteMenu(this);
            Drag.AddDNDFunctions(this);
            label = label_cats_header;
            l1 = categories_linklabel;

            asd = CategoriesParams;
            int result;
            if (CategoriesParams.Count < 2 || !Int32.TryParse(CategoriesParams[0], out result))
            {
                return;
            }
            //Сюда бы значение по умолчанию
            InitCategoriesLabels(this.Controls, Convert.ToInt32(CategoriesParams[0]));
        }

        /// <summary>
        /// Добавляет лейблы из базы
        /// </summary>
        /// <param name="ctr">Списпок контролов куда все вставлять</param>
        /// <param name="limit">Количество категорий</param>
        public static void InitCategoriesLabels(ControlCollection ctr, int limit)
        {
            List<string> Categories = SQLClass.Select("SELECT Name FROM Categories ORDER BY Name LIMIT 0," + limit);

            for (int i = 0; i < Categories.Count; i++)
            {
                Label label = new Label
                {
                    Size = new Size(100, 30),
                    Location = new Point(0, i * 30 + 30),
                    Text = Categories[i].ToString()
                };
                label.Click += new EventHandler(lable_cat_Click);

                ctr.Add(label);
            }
        }

        public static void RefreshUC(Control th, int Kolich)
        {
            th.Controls.Clear();
           
            th.Controls.Add(CategoriesUserControl.label);
            //Сюда бы значение по умолчанию
            InitCategoriesLabels(th.Controls, Kolich);
        }

        /// <summary>
        /// Добавление UserControl с категориями
        /// </summary>
        public static void AddNewBlock(object sender, EventArgs e)
        {
            Control c = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            UCParameters p = new UCParameters("CategoriesUserControl", new List<string>() {"2", "2" });
            p.ShowDialog();
            if(p.ParamsList != new List<string>())
            {
                CategoriesUserControl a1 = new CategoriesUserControl(p.ParamsList);
                string shsvfhksv = "";
                foreach (string asd in p.ParamsList)
                {
                    shsvfhksv += asd + ',';
                }
                a1.Controls.Add(CategoriesUserControl.l1);
                Menus.InsertBlockToDB(sender, a1, shsvfhksv);
            }
        }

        /// <summary>
        /// Клик на конкретную категорию
        /// </summary>
        public static void lable_cat_Click(object sender, EventArgs e)
        {
            Configs.SELECTED_CATEGORY = ((Label)sender).Text;
            GhostMainForm.MozhnoVvoditBukvyVPoisk = false;
        }

        private void CategoriesUserControl_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Открываем все категории
        /// </summary>
        private void categories_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoriesForm form3 = new CategoriesForm(false);
            form3.ShowDialog(); 
        }
    }
}
