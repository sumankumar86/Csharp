using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExmple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Non-generics
            var obj = new Queue();
            obj.Enqueue(1);
            obj.Enqueue("Suman");
            obj.Enqueue(null);
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }

            obj.Dequeue();
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }
            obj.ToArray();
            
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }
            //Generics
            Queue<string> obj1 = new Queue<string>();
            obj1.Enqueue("Suman");
            obj1.Enqueue("Apu");
            obj1.Enqueue("Sunanda");
            obj1.Enqueue("Anik");

            foreach(var item in obj1)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(obj1.Peek());
            Console.WriteLine(obj1.Count);
            Console.WriteLine(obj1.Contains("Suman"));
         
            
        }
    }
}
