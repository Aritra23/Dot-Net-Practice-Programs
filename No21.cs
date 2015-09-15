using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MettlHandson
{
    class No21
    {
        public Dictionary<string, string> getStates(string data, char del1, char del2)
        {
            Dictionary<string, string> dt = new Dictionary<string, string>();
            string[] s2 = data.Split(del2);
            for (int i = 0; i < s2.Length; i++)
            {
                dt.Add(s2[i].Substring(0, s2[i].IndexOf('|')), s2[i].Substring(s2[i].LastIndexOf('|') + 1));
            }
            return dt;
        }
        //public static void Main(string[] args)
        //{
        //    No21 ob = new No21();
        //    string s = "tamilnadu||chennai-karanataka||bengaluru";
        //    Dictionary<string, string> dt = ob.getStates(s, '|', '-');
        //    foreach (KeyValuePair<string, string> kvp in dt)
        //    {
        //        Console.WriteLine("key {0} value {1}", kvp.Key, kvp.Value);
        //    }
        //    Console.ReadLine();


        //}
    }
}
