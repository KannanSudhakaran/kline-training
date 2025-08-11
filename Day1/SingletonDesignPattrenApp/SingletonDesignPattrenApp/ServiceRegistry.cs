using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattrenApp
{
    internal class ServiceRegistry
    {
        private  static ServiceRegistry _bucket;
        private ServiceRegistry() {

            Console.WriteLine("service registry created");
        }

        public static ServiceRegistry CreateInstance() { 
        
            if(_bucket == null) {
               _bucket = new ServiceRegistry();
            }

            return _bucket;
        }

        //instance method
        public void DoWork() {
            Console.WriteLine("Service registry id doing some work..");
        }
    }
}
