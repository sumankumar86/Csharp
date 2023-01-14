using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder obj = new StringBuilder();
            obj.Append("Hello");
            obj.Append("World");
            obj.AppendLine("World!");
            Console.WriteLine(obj);
            StringBuilder obj1 = new StringBuilder(50);
            StringBuilder obj2 = new StringBuilder("Suman",50);
            Console.WriteLine(obj2);
            Console.WriteLine(obj1);
        }
    }
}
