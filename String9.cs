using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String9
    {
        public string matchedStringLength(string input1, string input2)
        {
            int n1 = input1.Length;
            int n2 = input2.Length;
            string output = "";
            int d = 0;
            if (n1 > n2)
            {
                d = n1 - n2;
                output = input1.Substring(d) + input2;
            }
            else if (n1 < n2)
            {
                d = n2 - n1;
                output = input1 + input2.Substring(d);
            }
            else
            {
                output = input1 + input2;
            }
            return output;
        }
        //static void Main(string[] args)
        //{
        //    String9 ob = new String9();
        //    Console.WriteLine(ob.matchedStringLength("hello", "hi"));
        //    Console.ReadLine();
        //}

                
    }
}
