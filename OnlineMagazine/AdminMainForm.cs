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

namespace WindowsFormsApplication4
{
   

    public struct users
    {
        public string login;
        public string password;
        public Boolean ban;
        public Button btn;
        public Button ras;
    }

    public partial class AdminMainForm : Form
    {
        public List<AuthorStat> writer = new List<AuthorStat>();

        public List<Reklama> mnogo_reklamy = new List<Reklama>();
        public AdminMainForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Кнопка открытия списка рекламы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            Spisok_reklamy sps = new Spisok_reklamy(mnogo_reklamy);
            sps.ShowDialog();
        }


        /// <summary>
        /// Переход на форму для Госструктур
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_author_Click(object sender, EventArgs e)
        {
            FBIform form = new FBIform();
            form.ShowDialog();
        }

        /// <summary>
        /// Открыть форму статистики
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_statistika_Click(object sender, EventArgs e)
        {
            StastisticsForm form1 = new StastisticsForm("", true);
            form1.ShowDialog();
        }
        
        /// <summary>
        /// Все пользователи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_all_users_Click(object sender, EventArgs e)
        {
            Users form = new Users();
            form.ShowDialog();
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifr = Application.OpenForms[0];
            ifr.Left = this.Left;
            ifr.Top = this.Top;
            ifr.Show();
        }

        /// <summary>
        /// Подборки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Collections coll = new Collections();
            coll.ShowDialog();
        }

       /// <summary>
       /// Форма проверки новых статей
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button_new_staty_Click(object sender, EventArgs e)
        {
            NewPages np = new NewPages();
            np.ShowDialog();
        }

        /// <summary>
        /// Категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_categories_Click_1(object sender, EventArgs e)
        {
            CategoriesForm form = new CategoriesForm(true);
            form.ShowDialog();
        }

       /// <summary>
       /// список авторов
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button_author_Click_1(object sender, EventArgs e)
        {
            List_of_author form = new List_of_author();
            form.ShowDialog();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;
        }

        /// <summary>
        /// Форма чтения логов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            LogsReadForm t = new LogsReadForm();
            t.ShowDialog();
        }

        /// <summary>
        /// Нервная форма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_list_of_mat_Click(object sender, EventArgs e)
        {
            Dostalo g = new Dostalo();
            g.Show();
        }

        /// <summary>
        /// Форма дизайнера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_look_of_form_Click(object sender, EventArgs e)
        {
            Designer form = new Designer();
            form.ShowDialog();
        }
    }
}