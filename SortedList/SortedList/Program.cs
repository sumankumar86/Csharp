using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> obj = new SortedList<int, string>();
            obj.Add(1, "Suman");
            obj.Add(2, "Anik");
            obj.Add(10, "Apu");
            obj.Add(20, "Sonu");
            obj.Add(11, "Boski");
            foreach(KeyValuePair<int, string> pair in obj)
            {
                Console.WriteLine($"key:{pair.Key},value:{pair.Value}");
            }

            //updated
            obj[10]="Suman";
            foreach (KeyValuePair<int, string> pair in obj)
            {
                Console.WriteLine($"key:{pair.Key},value:{pair.Value}");
            }

            //remove
            obj.Remove(11);
            obj.Remove(15);
            foreach (KeyValuePair<int, string> pair in obj)
            {
                Console.WriteLine($"key:{pair.Key},value:{pair.Value}");
            }
            Console.WriteLine(obj.Count);
            obj.RemoveAt(obj.Count-1);
            foreach (KeyValuePair<int, string> pair in obj)
            {
                Console.WriteLine($"key:{pair.Key},value:{pair.Value}");
            }
            Console.WriteLine(obj.Count);
            SortedDictionary<string, string> obj1 = new SortedDictionary<string, string>();
            obj1.Add("Abc", "Apple,Guava,Bannana");
            obj1.Add("Xyz", "Suman,Anik,Apu");
            obj1.Add("khln", "Toy,car,bike");
            foreach(var item in obj1)
            {
                Console.WriteLine("Key:{0},Value:{1}", item.Key, item.Value);
            }
        }
    }
}
