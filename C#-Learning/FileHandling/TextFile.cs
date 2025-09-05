using C__Learning.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.FileHandling
{
    internal class TextFile
    {
        // root path for the application
        private readonly string _rootPath = AppDomain.CurrentDomain.BaseDirectory;

        private string _fileName;

        public TextFile(string fileName)
        {
            _fileName = fileName;
        }

        public void writeText(string[] lines)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Path.Combine(_rootPath, _fileName), true))
                {
                    foreach (var line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }


        }

        public string ReadText()
        {
            try
            {
                using StreamReader reader = new StreamReader(Path.Combine(_rootPath, _fileName));
                return reader.ReadToEnd();
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
