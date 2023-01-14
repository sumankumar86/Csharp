using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringvs
{
    class Example
    {
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine(sb.GetHashCode());
            sb.Append("Worl");
            Console.WriteLine(sb.GetHashCode());
            Console.WriteLine(sb.Equals(sb));
          
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);

            String str = "Hello";
            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str.Equals(sb));
            str = str + "World";
            Console.WriteLine(str.GetHashCode());
            string a = "Suman";
            string b = "Suman";
            Console.WriteLine(a.Equals(b));
            
        }
    }
}
