using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String1
    {
        public string fun2(string input1)
        {
            string output = "";
            char[] ch = input1.ToCharArray();
            HashSet<char> hs = new HashSet<char>(ch);
            foreach(char b in hs)
            {
                output+=b;
            }
            return output;
        }
        /*static void Main(string[] args)
        {
            String1 ob = new String1();
           
            Console.WriteLine(ob.fun2("kolkata"));
            Console.ReadLine();
        }*/

    }
}
