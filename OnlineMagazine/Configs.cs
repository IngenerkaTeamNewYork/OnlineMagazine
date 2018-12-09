using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication4
{
    /// <summary>
    /// Всякие глобальные переменные и константы
    /// </summary>
    public class Configs
    {
        /// <summary>
        /// Текущий шрифт
        /// </summary>
        public static Font USER_FONT;
        /// <summary>
        /// Шрифт для заголовка
        /// </summary>
        public static Font ZAGOLOVOK_FONT;
        /// <summary>
        /// Текущий цвет текста
        /// </summary>
        public static Color USER_COLOR;
      
        public static int RlacationX = 0;
        public static int RlacationY = 0;
        public static Point Rpont = new Point(RlacationX, RlacationY);
        public static int ChR = 5;

        /// <summary>
        /// Количество элементов в блоках категорий, авторов и подборок
        /// </summary>
        public static int KOL_VO_ELEMENTOV_Author = 0;
        public static int KOL_VO_ELEMENTOV_Categoriya = 0;
        public static int KOL_VO_ELEMENTOV_Podborka = 0;

        public static void read()
        {
            FileStream file2 = new FileStream("Temp.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file2); // создаем «потоковый читатель» и связываем его с файловым потоком
        
            while (reader.Peek() >= 0)
            {
                string stroka_iz_faila = reader.ReadLine().Trim();
                if (stroka_iz_faila.Length > "AUTHOR".Length && stroka_iz_faila.Substring(0, "AUTHOR".Length) == "AUTHOR")
                {
                    KOL_VO_ELEMENTOV_Author = Convert.ToInt32(stroka_iz_faila.Substring("AUTHOR = ".Length));
                }
                if (stroka_iz_faila.Length > "CATEGORIES".Length && stroka_iz_faila.Substring(0, "CATEGORIES".Length) == "CATEGORIES")
                {
                    KOL_VO_ELEMENTOV_Categoriya = Convert.ToInt32(stroka_iz_faila.Substring("CATEGORIES = ".Length));
                }
                if (stroka_iz_faila.Length > "COLLECTIONS".Length && stroka_iz_faila.Substring(0, "COLLECTIONS".Length) == "COLLECTIONS")
                {
                    KOL_VO_ELEMENTOV_Podborka = Convert.ToInt32(stroka_iz_faila.Substring("COLLECTIONS = ".Length));
                }
                if (stroka_iz_faila.Length > "CHR".Length && stroka_iz_faila.Substring(0, "CHR".Length) == "CHR")
                {
                    ChR = Convert.ToInt32(stroka_iz_faila.Substring("CHR = ".Length));
                }
            }

            reader.Close();
        }
    }
}