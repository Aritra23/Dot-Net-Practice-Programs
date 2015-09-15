using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class No12
    {
        public bool validateUserName(string input1)
        {
            string[] arr = input1.Split('_');
            bool output = false;
            if (arr[0].Length >= 8 && input1.EndsWith("job"))
            {
                output = true;
            }
            else
                output = false;
            return output;
        }
        /*static void Main(string[] args)
        {
            No12 ob = new No12();
            Console.WriteLine(ob.validateUserName("Assss_job"));
            Console.ReadLine();
        }*/
    }
}
