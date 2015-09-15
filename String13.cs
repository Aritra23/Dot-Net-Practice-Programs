using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String13
    {
        public bool checkPalindrome(string input)
        {
            bool output = false;
            int c = 0;
            char[] c1 = input.ToCharArray();
            char[] c2 = new char[c1.Length];
            for (int i = 0; i < c1.Length; i++)
            {
                c2[i] = c1[i];
            }
            Array.Reverse(c2);
            string output1 = new string(c2);
            if (output1 == input)
                output = true;
            SortedSet<char> s1 = new SortedSet<char>(c1);
            if (output == true)
            {
                foreach (char a in s1)
                {
                    if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                        c++;
                }
                if (c >= 2)
                {
                    output = true;
                }
                else
                {
                    output = false;
                }
            }
            return output;
        }
        //static void Main(string[] args)
        //{
        //    String13 ob = new String13();
        //    Console.WriteLine(ob.checkPalindrome("aebea"));
        //    Console.ReadLine();
        //}

    }
                

            
}
