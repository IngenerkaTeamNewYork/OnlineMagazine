using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using IniParser.Parser;
using System.IO;

namespace OnlineMag
{
    static class Program
    {
        public static ContextMenuStrip UserControlCMS;// { get; internal set; }
        public static ContextMenuStrip AddNewUserControlCMS;
        public static string proces = "Точка входа";
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            LogFile.WriteLine("main", "читаем конфиг");
            proces = "читаем конфиг";
            
            IniParser.Parser.IniDataParser aa = new IniParser.Parser.IniDataParser();
            Tables.ADVERTISMENT = aa.Parse(File.ReadAllText("config.ini"))["db"]["ADVERTISMENT"].ToString();
            Tables.ARTICLES = aa.Parse(File.ReadAllText("config.ini"))["db"]["ARTICLES"].ToString();
            Tables.AUTHORS = aa.Parse(File.ReadAllText("config.ini"))["db"]["AUTHORS"].ToString();
            Tables.BALANCE = aa.Parse(File.ReadAllText("config.ini"))["db"]["BALANCE"].ToString();
            Tables.CATEGORIES = aa.Parse(File.ReadAllText("config.ini"))["db"]["CATEGORIES"].ToString();
            Tables.SETTINGS = aa.Parse(File.ReadAllText("config.ini"))["db"]["SETTINGS"].ToString();

            Configs.ReadTableNames();
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 s = new Form1();
            s.Show();
            SQLClass.OpenConnection();
            Application.Run(new GhostMainForm());

            SQLClass.CloseConnection();
        }
    }
}
