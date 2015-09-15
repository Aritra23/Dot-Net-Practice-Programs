using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class No11
    {
        public string getDayOfWeek(string date, string dateFormat)
        {
            DateTime dt = DateTime.ParseExact(date, dateFormat, null);
            string output = "";
            output = dt.DayOfWeek.ToString();
            return output;
        }
        /*static void Main(string[] args)
        {
            No11 ob = new No11();
            Console.WriteLine(ob.getDayOfWeek("05/03/2014", "dd/MM/yyyy"));
            Console.ReadLine();
        }*/
    }
}
