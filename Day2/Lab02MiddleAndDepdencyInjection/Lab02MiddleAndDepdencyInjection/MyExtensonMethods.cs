using System.Collections.Generic;
using System.Linq;


namespace Lab02MiddleAndDepdencyInjection
{

  
    public static class MyExtensonMethods
    {

        public static string Howdy(this string input) { 
                
          
            return $"Howdy {input}";
        }

        public static string Howdy2(this IEnumerable<string> input)
        {
            return $"Howdy";
        }


    }
}
