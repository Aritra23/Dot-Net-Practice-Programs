using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracLab
{
    class passwordvalidation
    {
        public bool passval(string input)
        {
            bool flag = false;
            int c = 0;
            char[] ch = input.ToCharArray();
            //1
            int c1 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(ch[i]))
                    c1++;
            }
            if (c1 >= 1)
                c++;
            //2
            int c2 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(ch[i]))
                    c2++;
            }
            if (c2 >= 1)
                c++;
            //3
            int c3 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(ch[i]))
                    c3++;
            }
            if (c3 == 0)
                c++;
            //4
            if (char.IsLetter(ch[0]))
                c++;
            //5
            int c4 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(ch[i]))
                    c4++;
            }
            if (c4 == 1)
                c++;
            //6
            int c5 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetterOrDigit(ch[i]))
                    c5++;
            }
            if (c5 == 1)
                c++;
            //7
            if (ch.Length >= 7 && ch.Length <= 9)
                c++;
            if (c == 7)
                flag = true;
            else
                flag = false;
            return flag;
        }

        //static void Main(string[] args)
        //{
        //    passwordvalidation ob = new passwordvalidation();
        //    Console.WriteLine(ob.passval("DN1$d"));
        //    Console.ReadLine();
        //}
    }
}
