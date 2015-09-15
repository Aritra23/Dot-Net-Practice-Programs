using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Prob28
    {
      
            public static int op;
        public static void flight(string[] ip)
        {
            int c = 0;            
            //1
            int c1 = 0;
            List<string> li = new List<string>();
            for (int i = 0; i < ip.Length; i++)
            {
                string str = ip[i];
                string[] spl = str.Split(',');
                li.Add(spl[0]);
            }
                for (int j = 0; j < li.Count-1; j++)
                {
                    if (li[j] != li[j + 1])                    
                        c1++;                    
                }
            
            if (c1 == ip.Length - 1)
                c++;
            //Console.WriteLine(c);
            //2
            int c2 = 0;
            if (c == 1)
            {
                for (int i = 0; i < ip.Length; i++)
                {
                    string str = ip[i];
                    if (str.Substring(0, 2) == "9W")
                        c2++;
                }
                if (c2 == ip.Length)
                    c++;
            }
            //Console.WriteLine(c);
            //3
            int c3 = 0;
            if (c == 2)
            {
                for (int i = 0; i < ip.Length; i++)
                {
                    string str = ip[i];
                    string[] spl = str.Split(',');
                    if (spl[1] != spl[2])
                        c3++;
                }
                if (c3 == ip.Length)
                    c++;
            }
            //Console.WriteLine(c);
            //4
            int c4 = 0;
            List<string> li1 = new List<string>();
            List<string> li2 = new List<string>();
            if (c == 3)
            {
                for (int i = 0; i < ip.Length; i++)
                {
                    string str = ip[i];
                    string[] spl = str.Split(',');
                    li1.Add(spl[1]);
                    li2.Add(spl[2]);
                }
                    for (int j = 0; j < li1.Count - 1; j++)
                    {
                        if (li1[j] != li1[j + 1] && li2[j] != li2[j+1])
                            c4++;
                    }
                
                if (c4 == ip.Length - 1)
                    c++;
            }
           // Console.WriteLine(c);
            //5
            int c5 = 0;
            if (c == 4)
            {
                for (int i = 0; i < ip.Length; i++)
                {
                    string str = ip[i];
                    string[] spl = str.Split(',');
                    int cap = Convert.ToInt32(spl[3]);
                    if (cap >= 30 && cap <= 100)
                        c5++;
                }
                if (c5 == ip.Length)
                    c++;
            }
            //Console.WriteLine(c);
            if (c == 5)
                op = ip.Length;
            else
                op = -1;
        }
        static void Main(string[] args)
        {
            string[] a = { "9W225,Chennai,Kolkata,30", "9W235,Kolkata,Chennai,40", "9W245,Bengaluru,Delhi,50" };
            Prob28.flight(a);
            Console.WriteLine(Prob28.op);
            Console.ReadLine();
        }
    }
}

          