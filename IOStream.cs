using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MettlHandson
{
    class IOStream
    {
        public void directory_fun()
        {
            string path=@"C:\mydir";
            string[] files = Directory.GetFiles(path);

            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Console.WriteLine("directory removed");
            }
            else
            {
                Console.WriteLine("Invalid Path");
            }
            Directory.CreateDirectory(path);
            Console.WriteLine("done");
        }
        public void write()
        {
            string path = @"C:\mydir\file1";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string str;
            Console.WriteLine("enter some text");

            str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void read()
        {
            string path = @"C:\mydir\file1";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str;
            Console.WriteLine("displaying your text");

            str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }

            Console.WriteLine("done");
            sr.Close();
            fs.Close();
        }
        //static void Main()
        //{
        //    IOStream obj = new IOStream();
        //   // obj.directory_fun();
        //   // obj.write();
        //    obj.read();
        //    Console.ReadLine();
        //}
    }
}
