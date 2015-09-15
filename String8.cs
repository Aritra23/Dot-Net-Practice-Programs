using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String8
    {
        public string getAppend(string input1)
        {
            string output = "";
            char[] ch = input1.ToCharArray();
            Array.Reverse(ch);
            for (int i = 0; i < ch.Length; i++)
            {
                if (i == (ch.Length - 1))
                    output += ch[i];
                else
                    output += ch[i] + "-";
            }
            return output;
        }
        //static void Main(string[] args)
        //{
        //    String8 ob = new String8();
        //    Console.WriteLine(ob.getAppend("computer"));
        //    Console.ReadLine();
        //}
    }
}
