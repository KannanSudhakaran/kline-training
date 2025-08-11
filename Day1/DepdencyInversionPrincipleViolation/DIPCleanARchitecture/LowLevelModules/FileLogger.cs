using DIPCleanARchitecture.HighLevelModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPCleanARchitecture.LowLevelModules
{
    internal class FileLogger : ILogger
    {
        public void Log(Exception ex)
        {
            Console.WriteLine("inside file logger");
            Console.WriteLine(ex.Message);
        }
    }
}
