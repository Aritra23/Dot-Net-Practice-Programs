using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class LinQ
    {
        public void fun1()
        {
            var v1 = 5;
            var v2 = "test string";
            Console.WriteLine(v1.GetType());
            Console.WriteLine(v2.GetType());
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var num = from n in numbers
                      where (n > 5)
                      select n;          //deferred execution

            int num1 = (from n in numbers
                       where (n % 2 == 0 && n > 5)
                       select n).Sum();
            Console.WriteLine(num1);
            int[] num2 = (from n in numbers
                          where (n > 5)
                          select n).ToArray(); //Immediate execution

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            foreach (int i in num2)
            {
                Console.WriteLine(i);
            }

        }
        public void fun2()
        {
            string[] yourArray = {"A", "B", "C", "D", "B", "b" };
            int val = (from str in yourArray
                       where (str.ToLower().Contains('b'))
                       select str).Count();
            Console.WriteLine(val);
        }
        public void fun3()
        {
            string[] yourArray = { "hello", "hi", "value", "xyz", "there", "bye" };
            var val = from str in yourArray
                      where (str.ToLower().Contains('h'))
                      select str;

            foreach (string s in val)
            {
                Console.WriteLine(s);
            }
        }
        public void fun4()
        {
            string text = "kolkata";
            char[] ch2 = (from c in text
                          group
                          c by c into g
                          where g.Count() == 1
                          select g.Key).ToArray();

            char[] ch1 = (from c in text
                          select c).Distinct().ToArray();

            string str3 = new string(ch1);
            Console.WriteLine(str3);
        }
        public void fun5()
        {
            string input = "ssssaabbbebbbbee";

            var v = (from t in input
                     group t by t into g
                     select new { charr = g.Key, count = g.Count() });
            foreach (var val in v)
            {
                Console.WriteLine("key = {0} value = {1}", val.charr, val.count);
            }

            Dictionary<char, int> frequency = (from t in input
                                               group t by t into g
                                               orderby g.Count() descending
                                               select new { v = g.Key, c = g.Count() }).ToDictionary(g => g.v, g => g.c);
            
            int max = 0;
            char maxChar = new char(); ;
            Dictionary<char, int> maxFreq = input.GroupBy(g => g).ToDictionary(g => g.Key, g => g.Count());

            foreach (KeyValuePair<char, int> kvp in maxFreq)
            {
                if (kvp.Value > max)
                {
                    max = kvp.Value;
                    maxChar = kvp.Key;
                }
            }
            Console.WriteLine("max repeated char: " + maxChar);


            foreach (KeyValuePair<char, int> kvp in frequency)
                Console.WriteLine(kvp);


        }


        //static void Main(string[] args)
        //{
        //    LinQ ob = new LinQ();
        //    //ob.fun1();
        //    //ob.fun2();
        //    //ob.fun3();
        //    //ob.fun4();
        //    ob.fun5();
        //    Console.ReadLine();
        //}
    }
}
