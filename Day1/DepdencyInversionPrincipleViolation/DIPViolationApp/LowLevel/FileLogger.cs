using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LowLevel
{
    internal class FileLogger
    {
        public void Log(Exception ex)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("FileLogging...!!");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();


        }
    }
}
