using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob4
    {
        public static string output;
        public static void AddYears(int n, string dt)
        {
            try
            {
                DateTime dt1 = DateTime.ParseExact(dt, "MM/dd/yyyy", null);
                output = dt1.AddYears(n).ToString("yyyy");
                
            }
            catch (Exception e)
            {
                output = "-1";
            }
          
        }
        //static void Main(string[] args)
        //{
        //    Prob4.AddYears(3, "10/03/2014");
        //    Console.WriteLine(Prob4.output);
        //    Console.ReadLine();
        //}
          


    }
}
