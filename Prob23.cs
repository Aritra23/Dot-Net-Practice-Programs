using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob23
    {
        public static List<int> output;
        public static void fun1(List<int> input1, int input2, int input3)
        {
            output = new List<int>();
            int[] a = input1.ToArray();
            for (int i = 0; i < input1.Count; i++)
            {
                output.Add(a[i]);
            }
                
                output.Insert(input3, input2);
            


        }
        //static void Main(string[] args)
        //{
        //    List<int> list1 = new List<int>();
        //    list1.Add(1);
        //    list1.Add(2);
        //    list1.Add(3);
        //    list1.Add(4);
        //    list1.Add(6);
        //    Prob23.fun1(list1, 5, 4);
        //    List<int> op = new List<int>();
        //    op = Prob23.output;
        //    foreach (var item in op)
        //        Console.WriteLine(item);
        //    Console.ReadLine();
        //}

        }
    }
