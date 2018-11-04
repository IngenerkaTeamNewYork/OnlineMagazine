using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public class Advertising
    {
        public struct Reklama
        {
            public Image kartinka;
            public string adress;
            public string text;
            public string video_adress;
            public List<String> list_of_categories;
        }
        
        /// <summary>
        /// Случайная реклама
        /// </summary>
        public static String GetRandom()
        {
            String reklPic = "https://i.imgur.com/eQ4wEpO.gif";
            Random rnd = new Random();
            int v = rnd.Next(1, 3);

            List<String> reklPics = SQLClass.Select("SELECT pic FROM " + Tables.ADVERTISMENT + " WHERE id =" + v);
            if (reklPics[0] != "")
            {
                reklPic = reklPics[0].ToString();
            }

            return reklPic;
        }
    }
}
