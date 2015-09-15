using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String4
    {
        public int samecountWord(string input1, string input2)
        {
            int c = 0, output = 0;
            string[] a = input1.Split(' ');
            string[] b = input2.Split(' ');

            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    char[] c1 = a[i].ToCharArray();
                    char[] c2 = b[i].ToCharArray();

                    Array.Sort(c1);
                    Array.Sort(c2);

                    string s1 = new string(c1);
                    string s2 = new string(c2);

                    if (s1 == s2)
                        c++;
                }
            }
            if (c == a.Length)
                output = 1;
            else
                output = 2;
            return output;
        }


        //static void Main(string[] args)
        //{
        //    String4 ob = new String4();
        //    Console.WriteLine(ob.samecountWord("hello there", "ohlle three"));
        //    Console.ReadLine();
        //}

           
                
    }
}
