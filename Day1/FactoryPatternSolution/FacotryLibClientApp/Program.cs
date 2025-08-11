
using FacotryCoreLib.Factory;

var factory = new AutoMobileFactory();
var auto =factory.Make(AutoMobileType.Tesla);
auto.Start();
auto.Stop();


var factory2 = new AutoMobileFactory();
var auto2 = factory.Make(AutoMobileType.Tesla);
auto.Start();
auto.Stop();
