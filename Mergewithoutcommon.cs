using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Mergewithoutcommon
    {
        public int[] fun1(int[] input1, int[] input2)
        {
            int[] output = new int[input1.Length + input2.Length];
            HashSet<int> hs1 = new HashSet<int>(input1);
            HashSet<int> hs2 = new HashSet<int>(input2);
            
            int[] output1 = hs1.ToArray();
            int[] output2 = hs2.ToArray();
            hs1.ExceptWith(hs2);
            HashSet<int> hs3=new HashSet<int>(output1);
            HashSet<int> hs4=new HashSet<int>(output2);

            hs4.ExceptWith(hs3);

            hs1.UnionWith(hs4);

            output = hs1.ToArray();
            return output;

           

        }
        /*static void Main(string[] args)
        {
            Mergewithoutcommon ob = new Mergewithoutcommon();
            int[] a = { 2, 5, 9, 1 };
            int[] b = { 2, 7, 9, 3 };
            int[] c = ob.fun1(a,b);
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
            Console.ReadLine();
        }*/
    }
}
