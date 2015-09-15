using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String15
    {
        public string formatString(string input1)
        {
            string a ="";

            string[] str = input1.Split('-');
            foreach (string s in str)
            {
                a += s;
            }
            string output = a.Substring(0, 2) + "-" + a.Substring(2, 2) + "-" + a.Substring(4, 3) + "-" + a.Substring(7);
            return output;
        }
        //static void Main(string[] args)
        //{
        //    String15 ob = new String15();
        //    Console.WriteLine(ob.formatString("555-666-1234"));
        //    Console.ReadLine();
        //}

        }
    }

