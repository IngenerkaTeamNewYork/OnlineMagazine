using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMag
{
    public static class LogFile
    {
        public static StreamWriter file;
        public static void WriteLine(string code, string text)
        {
            File.AppendAllText("logfile.txt", "[" +DateTime.Now + " - " + code + "] -- " + text+ "\r\n");
        }
    }
}
