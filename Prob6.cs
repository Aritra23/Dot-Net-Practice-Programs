using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob6
    {
        public static int output;
        public static void countPalindrome(string[] input)
        {
            int cnt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string s1 = input[i];
                char[] ch = s1.ToCharArray();
                Array.Reverse(ch);
                string s2 = new string(ch);
                if (s2 == input[i])
                {
                    cnt++;
                }
            }
            output = cnt;
        }
        //static void Main(string[] args)
        //{
        //    string[] a = { "madam", "rama", "badab" };
        //    Prob6.countPalindrome(a);
        //    Console.WriteLine(Prob6.output);
        //    Console.ReadLine();
        //}
 
    }
}
