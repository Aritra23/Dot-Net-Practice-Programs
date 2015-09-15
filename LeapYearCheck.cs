using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class LeapYearCheck
    {
        public int getLeapYear(string input1, string input2)
        {
            int output = 0;
            try
            {
                DateTime dt1 = DateTime.ParseExact(input1, "dd/MM/yyyy", null);
                DateTime dt2 = DateTime.ParseExact(input2, "dd/MM/yyyy", null);

                if (DateTime.Compare(dt2, dt1) == -1)
                    output = -1;
                else
                {
                    for (int i = dt1.Year + 1; i < dt2.Year; i++)
                    {
                        if (DateTime.IsLeapYear(i))
                        {
                            output++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                output = -1;
            }
            return output;
        }
        //static void Main(string[] args)
        //{
        //    LeapYearCheck ob=new LeapYearCheck();
        //    Console.WriteLine(ob.getLeapYear("20/10/2000","20/10/2014"));
        //    Console.ReadLine();
        //}

    }
}
