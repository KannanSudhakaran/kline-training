using DIPCleanARchitecture.HighLevelModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPCleanARchitecture.LowLevelModules
{
    internal class WindowsEventLogger: ILogger
    {
        public void Log(Exception ex)
        {
            Console.WriteLine("inside windows event logger");
            Console.WriteLine(ex.Message);
        }
    }
}
