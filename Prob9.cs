using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob9
    {
        public static List<int> output;
        public static void listApp(string[] input)
        {
            output = new List<int>(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                output.Add(input[i].Length);
              
            }
            output.Sort();
            output.Reverse();
           
           
        }
        //static void Main(string[] args)
        //{
        //    string[] a = { "Ram", "Shyam", "Jadu", "Madhab"};
        //    Prob9.listApp(a);
        //    List<int> list1 = Prob9.output;
        //    foreach (var item in list1)
        //        Console.WriteLine(item);
        //    Console.ReadLine();
        //}
       

    }
}
