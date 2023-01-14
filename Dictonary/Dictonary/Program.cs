using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonaryex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("a", "Suman");
            dict.Add("bc", "Anik");
            dict.Add("cd", "Apu");
            dict.Add("c", "Boski");
            dict.Add("e", "Sriti");
            
            foreach(var item in dict)
            {
                Console.WriteLine("Key:{0},Value:{1}", item.Key, item.Value);
            }   

            if (dict.ContainsKey("cd")){
                Console.WriteLine("It is found");
            }
            string result;
            if (dict.TryGetValue("cd", out result))
            {
                Console.WriteLine(result);
            }
           
        }
    }
}
