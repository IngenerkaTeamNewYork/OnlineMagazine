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

namespace WindowsFormsApplication4
{
    public partial class CategoriesUserControl : UserControl
    {
        public List<string> asd;
        private Label label2;
        //public Label label1;
        public LinkLabel linkLabel1;
        public static Label allcat;
        public static Label namecat;
        private Label Cat;
        private LinkLabel allcategories;
        private Label label1;

        //   public DragAndDrop Drag = new DragAndDrop();
        public static Label label = new Label();

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
           // this.Controls.Add(label1);
            // Menus.AddDeleteMenu(this);
            // Drag.AddDNDFunctions(this);
            label = label2;
            allcat = 

            asd = CategoriesParams;
            int result;
            if (CategoriesParams.Count < 2 || !Int32.TryParse(CategoriesParams[0], out result))
            {
                return;
            }
            //Сюда бы значение по умолчанию
            List<string> Categories = SQLClass.Select("SELECT Name FROM Categories ORDER BY Name LIMIT 0," + Convert.ToInt32(CategoriesParams[0]));

            for (int i = 0; i < Categories.Count; i++)
            {
                Label label2 = new Label
                {
                    Size = new Size(100, 30),
                    Location = new Point(0, i * 30 + 30),
                    Text = Categories[i].ToString()
                };
                label2.Click += new EventHandler(lable_cat_Click);

                this.Controls.Add(label2);
            }
        }

        public static void RefreshUC(Control th, int Kolich)
        {
            th.Controls.Clear();

            th.Controls.Add(CategoriesUserControl.label);
            //Сюда бы значение по умолчанию
            List<string> Categories = SQLClass.Select("SELECT Name FROM Categories ORDER BY Name LIMIT 0," +
                Kolich);

            for (int i = 0; i < Categories.Count; i++)
            {
                Label label = new Label
                {
                    Size = new Size(100, 30),
                    Location = new Point(0, i * 30 + 30),
                    Text = Categories[i].ToString()
                };
                //label.Click += new EventHandler(lable_cat_Click);

                th.Controls.Add(label);
            }

        }

        /// <summary>
        /// Добавление UserControl с категориями
        /// </summary>
        /*public static void AddNewBlock(object sender, EventArgs e)
        {
            Control c = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            UCParameters p = new UCParameters("block.CategoriesUserControl", new List<string>() { "2", "2" });
            p.ShowDialog();
            if (p.ParamsList != new List<string>())
            {
                CategoriesUserControl a1 = new CategoriesUserControl(p.ParamsList);
                string shsvfhksv = "";
                foreach (string asd in p.ParamsList)
                {
                    shsvfhksv += asd + ',';
                }
                Menus.InsertBlockToDB(sender, a1, shsvfhksv);
            }
        }*/

        public static void lable_cat_Click(object sender, EventArgs e)
        {
            Configs.zapros_na_cat = ((Label)sender).Text;
        }

        private void CategoriesUserControl_Load(object sender, EventArgs e)
        {

            /*List<String> catsList = SQLClass.Select("SELECT Name FROM " + Tables.CATEGORIES + " LIMIT 0, " + Configs.KOL_VO_ELEMENTOV_Categoriya);

            int catY = 20;
            for (int artIndex = 0; artIndex < catsList.Count; artIndex++)
            {
                Label label1 = new Label();
                label1.Location = new Point(0, 20);
                label1.Size = new Size(100, 20);
                label1.Text = catsList[artIndex].ToString();
               // label1.Click += new System.EventHandler(GhostMainForm.Search_CLick);
                this.Controls.Add(label1);
                catY += 28;
            }*/
        }

        

        private void CategoriesUserControl_Load_1(object sender, EventArgs e)
        {

        }
        
        private void CategoriesUserControl_Load_2(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CategoriesUserControl
            // 
            this.Name = "CategoriesUserControl";
            this.Load += new System.EventHandler(this.CategoriesUserControl_Load_3);
            this.ResumeLayout(false);

        }

        private void CategoriesUserControl_Load_3(object sender, EventArgs e)
        {

        }
    }
}
