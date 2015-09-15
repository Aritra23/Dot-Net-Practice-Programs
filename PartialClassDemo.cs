using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    partial class PartialClassDemo
    {
        public void fun1()
        {
            Console.WriteLine("function 1");
        }
        public void fun2()
        {
            Console.WriteLine("function 2");
        }
        partial void fun5();


    }
}
