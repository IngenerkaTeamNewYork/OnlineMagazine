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
        public static Random rnd = new Random();
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
        public static List<String> GetRandom()
        {
            List<String> pics = new List<String>();

            String reklPic = "https://i.imgur.com/eQ4wEpO.gif";
            String ss = "https://i.imgur.com/eQ4wEpO.gif";

            List<String> reklPics = SQLClass.Select(
                "SELECT pic FROM " + Tables.ADVERTISMENT + 
                " WHERE pic != ''" +
                " AND STR_TO_DATE(Date_From, '%d.%m.%Y') <= now()" +
                " AND STR_TO_DATE(Data_to, '%d.%m.%Y')>= now() AND 'new' = 0");

            List<String> ssData = SQLClass.Select(
                "SELECT text FROM " + Tables.ADVERTISMENT + 
                " WHERE pic != ''" +
                " AND STR_TO_DATE(Date_From, '%d.%m.%Y') <= now()" +
                " AND STR_TO_DATE(Data_to, '%d.%m.%Y')>= now() AND 'new' = 0");

            int v = rnd.Next(1, reklPics.Count);
            if (reklPics[v - 1] != "" )
            {
                ss = ss[v - 1].ToString();
                reklPic = reklPics[v - 1].ToString();
            }

            pics.Add(reklPic);
            pics.Add(ss);

            return pics;            
        }
    }
}
