using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class DateDemo
    {
        public void fun1(string input1, string input2)
        {
           DateTime dt1 =DateTime.ParseExact(input1, "dd/MM/yyyy", null);
            DateTime dt2 = DateTime.ParseExact(input2, "dd/MM/yyyy", null);
            int n = (int)dt1.Subtract(dt2).TotalDays;
            int n1 = (n / 365);
            Console.WriteLine(n1);
        }
        //static void Main(string[] args)
        //{
        //    DateDemo ob = new DateDemo();
        //    string ip1 = "20/06/2013";
        //    string ip2 = "20/12/2012";
        //    ob.fun1(ip1, ip2);
        //    Console.ReadLine();
        //}

            
      
    }
}
