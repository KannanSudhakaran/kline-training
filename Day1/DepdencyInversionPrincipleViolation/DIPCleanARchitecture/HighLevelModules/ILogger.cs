using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPCleanARchitecture.HighLevelModules
{
    internal interface ILogger
    {
        void Log(Exception ex);
    }
}
