using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class other_class
    {
    }
    class parent
    {
        public virtual void callme()
        {
            Console.WriteLine("hello from base class");
        }

        class child : parent
        {
            public override void callme()
            {
                Console.WriteLine("hello from child class");
            }
            /* public static void Main(string[] args)
             {
                 int n = 5;
                 object o = n;//boxing
                 int n1 = (int)o;//unboxing

                 long l1 = (long)o;//this is not possible as we cannot convert a primtive type to a different type of wrapper class. e.g -int to Integer only.
                        
                 Console.WriteLine(l1);
                // parent p = new parent();
                 //child c = new child();
                 //p = c;
                 //p.callme();

                 /*c = (child)p;
                 c.callme();

                 object o = new child();

                 //other_class oc=(other_class)o;
                 parent p1 = (parent)o;
                 p1.callme();
                 */
            /*bool b = true;
           // int n = Convert.ToInt32(b);
            //Console.WriteLine(n);
            //Console.ReadLine();
        }*/


            //  }
        }
    }
}