using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class No18
    {
        public int[] getSorted(int[] input)
        {
            int[] arr = new int[input.Length];

            int k = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string str = input[i].ToString();
                char[] ch = str.ToCharArray();
                Array.Reverse(ch);
                string str1 = new string(ch);
                int temp = Convert.ToInt32(str1);
                arr[k] = temp;
                k++;

            }
            Array.Sort(arr);
            return arr;
        }
       /* static void Main(string[] args)
        {
            No18 ob=new No18();
            int[] a = {12,23,96,45};
            int[] b = ob.getSorted(a);
            for(int j=0; j<b.Length; j++)
            {
                Console.WriteLine(b[j]);
            }
            Console.ReadLine();
        }*/

    }
}
