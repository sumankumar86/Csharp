using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExmple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int>obj=new Stack<int>();
            obj.Push(10);
            obj.Push(20);
            obj.Push(30);
            obj.Push(40);
            obj.Push(50);
            foreach(int num in obj)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("");
            obj.Pop();
            foreach (int num in obj)
            {
                Console.WriteLine(num);
            }
            var obj1 = new Stack();
            obj1.Push(1);
            obj1.Push("Suman");
            obj1.Push(true);
            foreach(var item in obj1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(obj1.Peek());
            Console.WriteLine(obj1.Count);
        }
    }
}
