using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FacotryCoreLib.Products
{
    internal class Bmw : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Bmw starts");
        }

        public void Stop()
        {
            Console.WriteLine("Bmw stops");
        }
    }
}
