using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> obj = new LinkedList<int>();
            obj.AddLast(10);
            obj.AddLast(20);
            obj.AddLast(40);
            obj.AddFirst(90);
            obj.AddFirst(100);
            foreach(int num in obj)
            {
                Console.WriteLine(num);
            }
        
        }
    }
}
