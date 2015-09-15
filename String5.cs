using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String5
    {
        public int[] getSorted(int[] input)
        {
            int k = 0;
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                string s1 = input[i].ToString();
                char[] c1 = s1.ToCharArray();
                Array.Sort(c1);


                string s2 = new string(c1);

                int n = Convert.ToInt32(s2);
                output[k] = n;
                k++;
            }
            Array.Sort(output);
            return output;
        }
        //static void Main(string[] args)
        //{
        //    String5 ob = new String5();
        //    int[] a = { 21, 7813, 901, 354 };
        //    int[] b = (ob.getSorted(a));

        //    foreach (int c in b)
        //    {
        //        Console.WriteLine(c);
        //    }
        //    Console.ReadLine();
        //}
            


    }
}
