using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    class A
    {
        public void methodA()
        {
            Console.WriteLine("Inside class A");
        }
    }
    class B:A
    {
        public void methodB()
        {
            base.methodA();
            Console.WriteLine("Inside class B");
        }
    }
    class C : B
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
            C c= new C();
            c.methodA();
            c.methodB();
            c.methodC();

            B b = new C();
            b.methodA();
            b.methodB();
            
        }
    }
}
