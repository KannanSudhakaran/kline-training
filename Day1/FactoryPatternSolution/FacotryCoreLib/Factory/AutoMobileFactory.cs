using FacotryCoreLib.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotryCoreLib.Factory
{
    public enum AutoMobileType
    {
        Bmw,
        Tesla
    }
    public class AutoMobileFactory
    {

        public IAutoMobile Make(AutoMobileType type) { 
        
            if(type == AutoMobileType.Bmw)
            {
                return new Bmw();
            }
           
            return new Tesla();
            
           
        }
    }
}
