using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace MettlHandson
{
    class CollectionDemo
    {
        public void fun1()
        {
            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add('c');
            a1.Add("string1");

            ArrayList al2 = new ArrayList();
            al2.Add('a');
            al2.Add(5);

            int n = (int)a1[0];
            Console.WriteLine(n);
            a1[0] = 20;
            Console.WriteLine(a1.Count);
            Console.WriteLine(a1.Contains(55));
            Console.WriteLine(a1.IndexOf(55));
            //int[] num = (int[])a1.ToArray();

            a1.Add(45);
            a1.Add(12);
            a1.Add(67);


            a1.Insert(1, "new value");
            //a1.AddRange(al2);
            a1.InsertRange(1, al2);
            a1.Remove("string1");
            a1.RemoveAt(2);
            a1.RemoveRange(0, 2);

            foreach (object o in a1)
            {
                Console.WriteLine(o.ToString());
            }
        }
        public void fun2()
        {
            List<int> li = new List<int>();
            Hashtable ht = new Hashtable();
            ht.Add(1, 'a');
            ht.Add(5, 'f');
            ht.Add(7, 'h');
            ht.Add(9, 'y');


            ICollection ic = ht.Keys;
            foreach (object o in ic)
            {
                Console.WriteLine(o.ToString());
            }


            Console.WriteLine(ht.Contains(1));
            char c = (char)ht[9];
            Console.WriteLine(c);

            ht[9] = 'x';
            //Console.WriteLine(c);
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("key ={0} value ={1}", de.Key, de.Value);
            }

        }
        public void fun3()
        {
            SortedList s1 = new SortedList();
            s1.Add(9, 'a');
            s1.Add(5, 'f');
            s1.Add(7, 'h');


            Console.WriteLine(s1.GetKey(0));
            Console.WriteLine(s1.GetByIndex(0));

            

            foreach (DictionaryEntry de in s1)
            {
                Console.WriteLine("key ={0} value = {1}", de.Key, de.Value);
            }

        
        
        }




        /*public static void Main(string[] args)
        {
            CollectionDemo ob = new CollectionDemo();
            ob.fun3();
            Console.ReadLine();
        }*/
    }
}