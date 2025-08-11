

using DIPViolationApp.HighLevel;

var taxCalculator = new TaxCalculator(LogType.FileLog);
Console.WriteLine(taxCalculator.CalculateTax(100, 0)) ;
