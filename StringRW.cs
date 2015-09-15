using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace MettlHandson
{
    class StringRW
    {
        StringBuilder sb=new StringBuilder();
        public void Writer()
        {

            StringWriter sw = new StringWriter(sb);
            Console.WriteLine("Welcome to the profile program");

            Console.Write("Name :");
            string name = Console.ReadLine();
            sw.WriteLine("Name :" + name);

            Console.WriteLine("Age :");
            string age = Console.ReadLine();
            sw.WriteLine("Age :" + age);

            Console.WriteLine("Thank you");
            Console.WriteLine("Information saved");
            Console.WriteLine();

            sw.Flush();
            sw.Close();
        }
    }
}
