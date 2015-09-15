using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String7
    {
        public string maxLength(string input)
        {
            string[] s1=input.Split(' ');
            int s2;
            int max =0;
            string name = "";
            for(int i =0; i<s1.Length; i++)
            {
                s2 = s1[i].Length;
                if( s2 > max)
                {
                    max = s2;
                    name=s1[i];
                }
            }
            return name;
        }
        //static void Main(string[] args)
        //{
        //    String7 ob = new String7();
        //    Console.WriteLine(ob.maxLength("hello how are you aaaaa"));
        //    Console.ReadLine();
        //}
    }
}
