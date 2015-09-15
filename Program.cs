using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class Program
    {
        public void fun1()
        {
            DateTime dt = DateTime.Now;
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = new DateTime(2014,03,01,09,42,09);

            //Console.WriteLine(dt);
            //Console.WriteLine(dt.ToString("dd/MM/yy"));
            Console.WriteLine(dt.ToString("dddd-dd-MMMM-MM-yy HH:mm tt"));
        }
        public void fun2()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.DayOfYear);
            Console.WriteLine(dt.Month);
            /*if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("test value");
            }*/
            Console.WriteLine(dt.AddYears(1));
            DateTime dt1 = new DateTime(2014, 02, 01);
            Console.WriteLine(DateTime.DaysInMonth(dt1.Year, dt1.Month));
        }
        public void fun3()
        {
            DateTime dt=DateTime.Now;
            DateTime dt1=new DateTime(2014, 03, 01);
            DateTime dt2= new DateTime(2014, 02, 01);

            int n = (int)dt1.Subtract(dt2).TotalDays;
            Console.WriteLine(n);
            int i=DateTime.Compare(dt2, dt1);
            //Console.WriteLine(i);

           // Console.WriteLine(DateTime.IsLeapYear(dt.Year));
        }
        public void fun4()
        {
            string str = "13/03/2014";
            string str1 = "2014/03/05";
            DateTime dt;
           // DateTime dt = DateTime.Parse(str);
            //Console.WriteLine(DateTime.TryParse(str, out dt));
            //Console.WriteLine(dt);

            string str2 = "21052014";
            DateTime dt1 = DateTime.ParseExact(str2, "ddMMyyyy", null);
            string str3 = "210520141108";
            Console.WriteLine(DateTime.TryParseExact(str3, "ddMMyyyyHHmm", null, System.Globalization.DateTimeStyles.None, out dt));
            Console.WriteLine(dt);

            
        }
        public void fun5()
        {
            string str = "abhceklnm";
            //char[] ch = str.ToCharArray();
           // int flag=1;
           // char c = str[0];
            //Console.WriteLine(c);
            string str1 = "a test string";
            string str2= "a test string";
            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1.IndexOf("ring"));
            Console.WriteLine(str1.LastIndexOf("t"));
            Console.WriteLine(str1.Substring(2, 5));
            Console.WriteLine(str1.Contains("test"));
            //string[] str_arr = str1.Split(' ');
            string[] str_arr=str1.Split(new char[]{' ','t'});
           // Console.WriteLine(str_arr.Length);
            foreach (string s in str_arr)
            {
               // Console.WriteLine(s);
            }
            /*for (int i = 0; i < ch.Length; i++)
            {
                if (!char.IsLetterOrDigit(ch[i]))
                {
                    flag = 0;
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
            }*/

            //Array.Reverse(ch);
            //string str1 = new string(ch);
           // Console.WriteLine(str1);

        
        
        
        }


       /* static void Main(string[] args)
        {
            Program p = new Program();
            //p.fun1();
           // p.fun2();
           // p.fun3();
            //p.fun4();
            p.fun5();
            Console.ReadLine();

        }*/
    }
}
