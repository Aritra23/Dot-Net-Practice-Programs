using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String6
    {

        public string getNameMax(string[] input1)
        {
            int sum=0;
            int max=0;
            string output="";
            string name="";
            for (int i = 0; i < input1.Length; i++)
            {
                sum = 0;
                string[] s1 = input1[i].Split('#');
                for (int j = 1; j < s1.Length; j++)
                {
                    name = s1[0];
                    sum += Convert.ToInt32(s1[j]);
                }
                    if (sum > max)
                    {
                        max = sum;
                        output = name;
                    }
                }
        
            return output;

        }

        //static void Main(string[] args)
        //{
        //    String6 ob = new String6();
        //    string[] ip = { "Tom#20#30#50", "Sam#10#20#30", "Ron#20#30#40" };
        //    Console.WriteLine(ob.getNameMax(ip));
        //    Console.ReadLine();
        //}

    }
}
