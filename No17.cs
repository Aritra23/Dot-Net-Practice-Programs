using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class No17
    {
        public string[] votersList(string[] input)
        {
            string[] a = new string[20];
            int k = 0;
            for (int i = 0; i < input.Length; i += 2)
            {
                string id = input[i];
                string dob = input[i + 1];
                DateTime dt = DateTime.ParseExact(dob, "dd/MM/yyyy", null);
                DateTime dt1 = DateTime.Now;
                int n = (int)dt1.Subtract(dt).TotalDays;
                if ((n / 365) > 18)
                {
                    a[k] = id;
                    k++;
                }
            }
            return a;
        }
        /*static void Main(string[] args)
        {
            No17 ob = new No17();
            string[] arr = { "1", "24/07/1991", "2", "02/11/2000", "3", "09/03/1990", "4", "18/09/2013" };
            string[] arr1 = ob.votersList(arr);
            for (int j = 0; j < arr1.Length; j++)
            {
                Console.WriteLine(arr1[j]);
            }
            Console.ReadLine();
        }*/

    }
}
