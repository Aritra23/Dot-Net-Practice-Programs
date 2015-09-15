using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob5
    {
        public static int output;
        public static void vowelCount(string input)
        {
            char[] ch = input.ToCharArray();
            int cnt = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'A' || ch[i] == 'e' || ch[i] == 'E' || ch[i] == 'i' || ch[i] == 'I' || ch[i] == 'o' || ch[i] == 'O' || ch[i] == 'u' || ch[i] == 'U')
                {
                    cnt++;
                }
            }
            output = cnt;
        }
        //static void Main(string[] args)
        //{
        //    Prob5.vowelCount("Aritra");
        //    Console.WriteLine(Prob5.output);
        //    Console.ReadLine();
        //}
    }
}
