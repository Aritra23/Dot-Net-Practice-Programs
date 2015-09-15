using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String3
    {
         public string fun3(string input)
        {
            string output = "";
            int c = 0;
            char[] ch = input.ToCharArray();
            HashSet<char> hs = new HashSet<char>(ch);
            char[] ch1 = hs.ToArray();
            for (int i = 0; i < ch1.Length; i++)
            {
                c = 0;
                for (int j = 0; j < ch.Length; j++)
                {
                    if (ch1[i].Equals(ch[j]))
                    {
                        c++;
                    }
                }
                if (c > 1)
                {
                    output += ch1[i];
                }
            }
            return output;
        }

        /*static void Main(string[] args)
        {
            String3 ob = new String3();

            Console.WriteLine(ob.fun3("kolkata"));

            Console.ReadLine();
        }*/






    }
}
