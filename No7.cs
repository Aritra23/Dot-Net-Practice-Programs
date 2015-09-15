using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class No7
    {
        public string alterString(string input)
        {
            string output = "";
            char[] ch = input.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u' || ch[i] == 'A' || ch[i] =='E' || ch[i] =='I' || ch[i] == 'O' || ch[i] == 'U')
                {
                    output += (char)ch[i];
                }
                else
                {
                    output += (char)(ch[i] + 1);
                }
            }
            return output;
        }
        /*static void Main(string[] args)
        {
            No7 ob = new No7();
            Console.WriteLine(ob.alterString("AriTra"));
            Console.ReadLine();

        }*/

    }
}
