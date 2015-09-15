using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob10
    {
        public static int output;
        public static void countFrequency(string input1, string input2)
        {
            string[] str = input2.Split(' ');
            int cnt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (input1 == str[i])
                {
                    cnt++;
                }
            }
            output = cnt;
        }
        //static void Main(string[] args)
        //{
        //    string ip2 = "He is a good boy but his brother is not";
        //    string ip1 = "is";
        //    Prob10.countFrequency(ip1, ip2);
        //    Console.WriteLine(Prob10.output);
        //    Console.ReadLine();
        //}
    }
}
