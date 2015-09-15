using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob21
    {
        public static int output;
        public static void fun1(List<string> input1)
        {
            int max=0;
            int x = 0;
            int y=0;
            for (int i = 0; i < input1.Count; i++)
            {
                x = input1[i].Length;
                if (x > max)
                {
                    max = x;
                    y = i;
                }
            }
            output = y;

        }
        //static void Main(string[] args)
        //{
        //    List<string> list1 = new List<string>();
        //    list1.Add("Hi");
        //    list1.Add("Piano");
        //    list1.Add("Guitr");
        //    list1.Add("Violn");
        //    Prob21.fun1(list1);
        //    Console.WriteLine(Prob21.output);
        //    Console.ReadLine();
        //}

    }
}
