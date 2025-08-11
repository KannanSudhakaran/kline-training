using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotryCoreLib.Products
{
    internal class Tesla : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla starts");
        }
        public void Stop()
        {
            Console.WriteLine("Tesla stops");
        }
    }
   
}
