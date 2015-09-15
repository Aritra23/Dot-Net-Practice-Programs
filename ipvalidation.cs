using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class ipvalidation
    {
        public bool ipval(string input)
        {
            bool flag = false;
            int count = 0;
            string[] a = input.Split('.');
            if (a.Length == 4)
            {
                count++;
                if (Convert.ToInt32(a[0]) >= 0 && Convert.ToInt32(a[0]) <= 255)
                {
                    if (Convert.ToInt32(a[1]) >= 0 && Convert.ToInt32(a[1]) <= 255)
                    {
                        if (Convert.ToInt32(a[2]) >= 0 && Convert.ToInt32(a[2]) <= 255)
                        {
                            if (Convert.ToInt32(a[3]) >= 0 && Convert.ToInt32(a[3]) <= 255)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == 2)
                flag = true;
            else
                flag = false;
            return flag;
        }

        static void Main(string[] args)
        {
            ipvalidation ob = new ipvalidation();
            Console.WriteLine(ob.ipval("192.168.0"));
            Console.ReadLine();
        }

    }
}
