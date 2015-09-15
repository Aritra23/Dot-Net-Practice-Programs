using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class RomanToDecimal
    {
        public void roman()
        {
            string s = "XXVIII";
            List<int> list1 = new List<int>();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    list1.Add(1);
                }
                else if (s[i] == 'V')
                {
                    list1.Add(5);
                }

                else if (s[i] == 'X')
                {

                    list1.Add(10);
                }
                else if (s[i] == 'L')
                {
                    list1.Add(50);
                }
                else if (s[i] == 'C')
                {
                    list1.Add(100);
                }
                else if (s[i] == 'D')
                {
                    list1.Add(500);
                }
                else if (s[i] == 'M')
                {
                    list1.Add(1000);
                }
            }

            list1.Add(1);

            for (int i = 0; i < list1.Count - 1; i++)
            {
                sum = sum + list1[i];


                if (list1[i] < list1[i + 1])
                {
                    sum = sum - 2 * list1[i];
                }
            }
            Console.WriteLine(sum);
        }
        //static void Main(string[] args)
        //{
        //    RomanToDecimal ob = new RomanToDecimal();
        //   ob.roman();
        //    Console.ReadLine();
        //}
    }
}
