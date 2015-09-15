using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String11
    {
        public void integerToString(int input)
        {
            string s = Convert.ToString(input, 2);
            Console.WriteLine(s);
        }
        //static void Main(string[] args)
        //{
        //    String11 ob = new String11();
        //    ob.integerToString(64);
        //    Console.ReadLine();
        //}
    }
}
