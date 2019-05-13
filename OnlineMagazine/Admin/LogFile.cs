using System;
using System.IO;

namespace OnlineMag
{
    public static class LogFile
    {
        public static DateTime start_time = DateTime.Now;
        public static void WriteLine(string code, string text)
        {
            File.AppendAllText("logfile.txt", "[" + Math.Round((DateTime.Now - start_time).TotalMinutes, 2) + " мин - " + code + "] -- " + text + "\r\n");
        }
    }
}
