using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using IniParser.Parser;
using System.IO;

namespace WindowsFormsApplication4
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IniParser.Parser.IniDataParser aa = new IniParser.Parser.IniDataParser();
            Tables.ADVERTISMENT = aa.Parse(File.ReadAllText("config.ini"))["db"]["ADVERTISMENT"].ToString();
            Tables.ARTICLES = aa.Parse(File.ReadAllText("config.ini"))["db"]["ARTICLES"].ToString();
            Tables.AUTHORS = aa.Parse(File.ReadAllText("config.ini"))["db"]["AUTHORS"].ToString();
            Tables.BALANCE = aa.Parse(File.ReadAllText("config.ini"))["db"]["BALANCE"].ToString();
            Tables.CATEGORIES = aa.Parse(File.ReadAllText("config.ini"))["db"]["CATEGORIES"].ToString();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GhostMainForm());
        }
    }
}
