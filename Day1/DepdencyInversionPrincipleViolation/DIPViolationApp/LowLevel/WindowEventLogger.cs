using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LowLevel
{
    internal class WindowEventLogger
    {
        public void Log(Exception ex) { 
        
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("WindowsLogging...!!");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();


        }
    }
}
