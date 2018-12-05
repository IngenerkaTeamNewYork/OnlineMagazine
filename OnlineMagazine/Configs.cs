using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
