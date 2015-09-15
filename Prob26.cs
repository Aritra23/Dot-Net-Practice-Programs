using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob26
    {
        public static string output;
        public static void fun1(string input)
        {
            char[] ch = input.ToCharArray();
            Array.Reverse(ch);
            string s1 = new string(ch);
            string s2 = input + "|" + s1;
            output = s2;
        }
        //static void Main(string[] args)
        //{
        //    Prob26.fun1("EARTH");
        //    Console.WriteLine(Prob26.output);
        //    Console.ReadLine();

        //}
    }
}
