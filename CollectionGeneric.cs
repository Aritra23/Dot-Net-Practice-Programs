using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class CollectionGeneric
    {
        public void fun1()
        {
            Dictionary<int, char> dt1 = new Dictionary<int, char>();
            dt1.Add(9, 'a');
            dt1.Add(5, 'a');
            dt1.Add(4, 'a');

            
            foreach (KeyValuePair<int, char> kvp in dt1)
            {
                //Console.WriteLine("key ={0} value = {1}", kvp.Key, kvp.Value);
            }
            int[] arr = { 3, 1, 8 };
            HashSet<int> hs = new HashSet<int>(arr);

            hs.Add(3);
            hs.Add(9);
            hs.Add(5);
            hs.Add(1);
            //hs.Add(1);
            //hs.Add(3);

            
            //hs.ExceptWith(arr);
            int[] arr1 = hs.ToArray();
           // hs.IntersectWith(arr);
            hs.UnionWith(arr);
           
            


            //Console.WriteLine(hs.Max());
           // Console.WriteLine(hs.Average());
            foreach (int kvp in hs)
            {
                Console.WriteLine(kvp);
            }

        }
       /* static void Main(string[] args)
        {
            CollectionGeneric p = new CollectionGeneric();
            p.fun1();

            Console.ReadLine();
        }*/
    }
}