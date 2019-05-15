using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineMag
{
    public struct Statiya
    {
        public string ArticleName;
        public string AuthorName;
        public string Category;
        public string Text;
        public string PictureURL;

        /// <summary>
        /// Запрашивает статью из DB и возвращает <see cref="Statiya"/>
        /// </summary>
        /// <param name="ArticleName">Точное название статьи</param>
        /// <returns><see cref="Statiya"/> полученная из DB</returns>
        public static Statiya GetStatiyaFromArticleName(string ArticleName)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT Header, Author, Category, Text, Picture FROM " + Tables.ARTICLES + " WHERE `Header` = '" + ArticleName + "'", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            Statiya Stat = new Statiya
            {
                ArticleName = rdr[0].ToString(),
                AuthorName = rdr[1].ToString(),
                Category = rdr[2].ToString(),
                Text = rdr[3].ToString()
            };
            if (rdr[4].ToString() != "")
            {
                Stat.PictureURL = rdr[4].ToString();
            }
            else
            {
                Stat.PictureURL = null;
            }
            rdr.Close();

            return Stat;
        }

    }
}
