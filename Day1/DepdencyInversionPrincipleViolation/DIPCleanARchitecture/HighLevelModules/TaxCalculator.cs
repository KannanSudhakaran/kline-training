using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPCleanARchitecture.HighLevelModules
{
    internal class TaxCalculator
    {
        private readonly ILogger _logger;
        public TaxCalculator(ILogger logger)//has a reations
        {
            _logger = logger;
        }

        public int CalculateTax(int income, int rate)
        {
            int result = 0;
            try
            {
                result = income / rate;
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
            }
            return result;
        }
    }
}
