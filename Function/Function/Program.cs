using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Example
    {
        public void show()
        {
            Console.WriteLine("Inside method");
        }
        public void display(string name)
        {
            Console.WriteLine("Inside parameterized method:Name is {0}",name);

        }
        public string details(string name)
        {
            Console.WriteLine("Inside parameterized with return type");
            return name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example();
            obj.show();
            obj.display("Suman");
            string name=obj.details("Anik");
            Console.WriteLine(name);
        }
    }
}
