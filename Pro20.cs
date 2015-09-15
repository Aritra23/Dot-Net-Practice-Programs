using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Pro20
    {
        public static int output;
        public static void fun1(List<string> input1)
        {
            int cnt = 0;
            int max = 0;
            int x =0;
           string[] ip = input1.ToArray();
            for (int i = 0; i < ip.Length; i++)
            {
                cnt = 0;
                char[] ch = ip[i].ToCharArray();
                for (int j = 0; j < ch.Length; j++)
                {
                    if (ch[j] == 'a' || ch[j] == 'e' || ch[j] == 'i' || ch[j] == 'o' || ch[j] == 'u')
                    {
                        cnt++;
                    }
                }
                if (cnt >= max)
                {
                    max = cnt;
                    x = i;

                }
            }
            output = x;
        }
        //static void Main(string[] args)
        //{
        //    List<string> list1 = new List<string>();
        //    list1.Add("Hi");
        //    list1.Add("Piano");
        //    list1.Add("Guitr");
        //    list1.Add("Violn");
        //    Pro20.fun1(list1);
        //    Console.WriteLine(Pro20.output);
        //    Console.ReadLine();
        //}

    }
}
