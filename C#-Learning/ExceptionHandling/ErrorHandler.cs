using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.ExceptionHandling
{
    internal static class ErrorHandler
    {
        public static void Execute(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
                Console.WriteLine("An error occurred, check the logs.");
            }
        }
    }
}
