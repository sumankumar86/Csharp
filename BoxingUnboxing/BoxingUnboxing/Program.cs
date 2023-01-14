using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            int i = 10;
            object obj = i;
            Console.WriteLine(obj); 
            Console.WriteLine(i);
            //Unboxing
            object obj1 = 20;
            int j = (int)obj1;
            var ab = obj1;
            Console.WriteLine(j);
            Console.WriteLine(obj1);
            Console.WriteLine(ab);
        }
    }
}
