using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class String12
    {
        public string removeVowel(string input)
        {
            //string output = "";
            char[] c1 = new char[input.Length];
            int k = 0;
            char[] ch = input.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                    {
                        continue;
                    }
                    else
                    {
                        c1[k] = ch[i];
                        k++;
                    }

                }
                else
                {
                    c1[k] = ch[i];
                    k++;
                }
            }
            string output = new string(c1);
            return output;
          
        }
        //static void Main(string[] args)
        //{
        //    String12 ob =new String12();
        //    Console.WriteLine(ob.removeVowel("aritra"));
        //    Console.ReadLine();
        //}


    }
}
