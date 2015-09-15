using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    static class utility
    {
       public  static string calc_length(this Array a)
        {
            int i = a.Length;
            string str = "length = " + i + "";
            return str;
        }
       public static int Add_Int(this int a, int b)
       {
           
           return a + b;
       }

    }
    
}
