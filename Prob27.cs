using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob27
    {
        public static int output;
        public static void fun1(string[] input1)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            int c1 = 0, c2=0, c3=0, c4=0;
            for (int i = 0; i < input1.Length; i++)
            {
                string s1 = input1[i];
                DateTime dt1 = DateTime.ParseExact(s1, "dd/MM/yyyy", null);
                int s2 = dt1.Month;
                list1.Add(s2);
            }
            for (int j = 0; j < list1.Count; j++)
            {
                if (list1[j] >= 1 && list1[j] <= 3)
                    c1++;
                else if (list1[j] >= 4 && list1[j] <= 6)
                    c2++;
                else if (list1[j] >= 7 && list1[j] <= 9)
                    c3++;
                else if (list1[j] >= 10 && list1[j] <= 12)
                    c4++;
            }
            list2.Add(c1);
            list2.Add(c2);
            list2.Add(c3);
            list2.Add(c4);
            list2.Sort();
            output = list2[list2.Count - 1];


        }
        //static void Main(string[] args)
        //{
        //    string[] ip = { "20/06/2000", "14/02/2003", "23/12/1990", "10/07/2007" };
        //    Prob27.fun1(ip);
        //    Console.WriteLine(Prob27.output);
        //    Console.ReadLine();
        //}

       
    }
}
