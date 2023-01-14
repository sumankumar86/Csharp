using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Example
    {
        public static int num;
        public Example()
        {
            Console.WriteLine("Inside default cons");
        } 
        public Example(int a)
        {
            Console.WriteLine("Inside parameterized cons"+a);
        }
        static Example()
        {
            Console.WriteLine("Inside static cons");
            num=10;
        }
        public void show()
        {
            Console.WriteLine(num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            Example example1 = new Example(12);
            example.show();
        }
    }
}
