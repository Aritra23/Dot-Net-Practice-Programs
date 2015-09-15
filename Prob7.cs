using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob7
    {
        public static string output;
        public static void removeSpecialChar(string input)
        {
            output = "";
            foreach (var item in input)
            {
                if (!char.IsLetterOrDigit(item))
                    continue;
                else
                    output += item;
            }
        }
        //static void Main(string[] args)
        //{
        //    Prob7.removeSpecialChar("Aritra@123@!");
        //    Console.WriteLine(Prob7.output);
        //    Console.ReadLine();
        //}

    }
}
