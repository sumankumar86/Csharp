using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeriarchiLevelInheritance
{
    class A
    {
        public void methodA()
        {
            Console.WriteLine("Inside class A");
        }
    }  
    class B: A
    {
        public void methodB()
        {
            Console.WriteLine("Inside class B");
        }
    } 
    class C: A
    {
        public void methodC()
        {
            Console.WriteLine("Inside class C");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.methodC();
            c.methodA();

            B b = new B();
            b.methodA();
            b.methodB();
        }
    }
}
