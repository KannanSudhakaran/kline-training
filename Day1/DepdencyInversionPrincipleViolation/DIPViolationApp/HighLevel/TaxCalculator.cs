using DIPViolationApp.LowLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.HighLevel
{
    internal class TaxCalculator
    {
        private readonly LogType _logType;
        public TaxCalculator(LogType logType)
        {
            
            _logType = logType;
        }

        public int CalculateTax(int income, int rate) {

            int result = 0;

            try
            {
                result = income / rate;
            }
            catch (Exception ex) {

                if (_logType == LogType.WindowsEventLog)
                { 
                  var eventLogger =new WindowEventLogger();
                    eventLogger.Log(ex);
                }
                else
                {
                     var fileLogger = new FileLogger();
                    fileLogger.Log(ex);
                }

            }



            return result;

        }

    }
}
