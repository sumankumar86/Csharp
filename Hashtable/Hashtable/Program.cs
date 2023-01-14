using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtableex
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var obj = new Hashtable();
            obj.Add(10, "Suman");
            obj.Add("cd", "Apu");
            obj.Add(true, "Anik");

            Console.WriteLine(".............Insert.......");
            foreach (DictionaryEntry item in obj)
            {
                Console.WriteLine(item.Key+","+item.Value);
            }

            //Dictionary to hastable
            Console.WriteLine(".........Dictionary ........");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Khudrun");
            dict.Add(2, "Katwa");
            dict.Add(3, "Kolkata");
            dict.Add(4, "Burdwan");

            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }
            Hashtable newobj=new Hashtable(dict);
            Console.WriteLine(".........Dictionary to hastable........");
            foreach (DictionaryEntry item in newobj)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }
            Console.WriteLine(".............Update.......");
            newobj[2] = "Purba Katwa";
            foreach (DictionaryEntry item in newobj)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }
            newobj.Remove(0);
            Console.WriteLine(".............Remove.......");
            foreach (DictionaryEntry item in newobj)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }
        }
    }
}
