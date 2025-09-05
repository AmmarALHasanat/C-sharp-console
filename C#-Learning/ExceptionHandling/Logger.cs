using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace C__Learning.ExceptionHandling
{
    internal static class Logger
    {
        public static void Exception(Exception ex)
        {
            string errorTitle = ex.GetType().Name;
            string directoryPath = GetLogPath(errorTitle, "Error");

            // why not add try catch here to close my program and crach
            using (StreamWriter writer = new StreamWriter(directoryPath, true))
            {

                writer.WriteLine($"Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                writer.WriteLine("Exception Type: " + ex.GetType().FullName);
                writer.WriteLine("Message: " + ex.Message);
                writer.WriteLine("Source: " + ex.Source);
                writer.WriteLine("Target Site: " + ex.TargetSite);
                writer.WriteLine("Stack Trace:");
                writer.WriteLine(ex.StackTrace);
                writer.WriteLine();
            }
        }

        public static void Information(string message, string fileName)
        {
            string directoryPath = GetLogPath(fileName);

            
            using (StreamWriter writer = new StreamWriter(directoryPath, true))
            {
                writer.WriteLine($"{DateTime.Now}: Information");
                writer.WriteLine(message);
                writer.WriteLine();
            }
        }

        private static string GetLogPath(string fileName,string type= "Info")
        {
            DateTime now = DateTime.Now;
            string directoryPath = Path.Combine(
                "Logs",
                type,
                now.Year.ToString()+"_"+now.Month.ToString("D2")+"_"+now.Day.ToString("D2")
            );

            Directory.CreateDirectory(directoryPath);

            return Path.Combine(directoryPath, $"{fileName} {now.Hour.ToString("D2")}-{now.Minute.ToString("D2")}-{now.Second.ToString("D2")}.txt");
        }
    }
}
