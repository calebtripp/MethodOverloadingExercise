using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExercise
{
    internal class Methods
    {
        public static int Add(int a, int b)
        { 
            return a + b; 
        }
        public static decimal Add(decimal a, decimal b)
        { 
            return a + b; 
        }
        public static string Add(int a, int b, bool c)
        {
            if (c == true && (a+b) <=1)
            {
                return ($"{a + b} dollar");
            }
            else if (c == true && (a + b) >1)
            {
                return ($"{a + b} dollars");
            }
            else
            {
                return "Falsey false false";
            }
                     
        }
    }
}
