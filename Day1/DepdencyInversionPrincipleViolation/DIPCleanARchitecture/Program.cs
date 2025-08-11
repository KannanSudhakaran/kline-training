

using DIPCleanARchitecture.HighLevelModules;
using DIPCleanARchitecture.LowLevelModules;

var taxCa = new TaxCalculator(new DbLogger());

Console.WriteLine(taxCa.CalculateTax(100, 0));