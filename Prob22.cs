using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob22
    {
        public static int output;
        public static void fun1(Dictionary<string, int> input1)
        {
            int cnt = 0;
            foreach (KeyValuePair<string, int> kvp in input1)
            {
                if (((kvp.Value) % 4) == 0 || ((kvp.Value) % 400) == 0)
                {
                    cnt++;
                }
            }
            output = cnt;
        }
        //static void Main(string[] args)
        //{
        //    Dictionary<string, int> dt1 = new Dictionary<string, int>();
        //    dt1.Add("Ram", 2000);
        //    dt1.Add("Shyam", 2004);
        //    dt1.Add("Jadu", 2012);
        //    dt1.Add("Madhu", 2003);
        //    Prob22.fun1(dt1);
        //    Console.WriteLine(Prob22.output);
        //    Console.ReadLine();
        
        //}
    }
}
