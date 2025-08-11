

using SingletonDesignPattrenApp;

var regstry1 =  ServiceRegistry.CreateInstance();
var regstry2 = ServiceRegistry.CreateInstance();

Console.WriteLine(regstry1.GetHashCode());
Console.WriteLine(regstry2.GetHashCode());

regstry1.DoWork();
regstry2.DoWork();

