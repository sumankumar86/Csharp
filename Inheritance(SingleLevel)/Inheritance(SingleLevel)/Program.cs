using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_SingleLevel_
{
    class A
    {
        public void show(string name)
        {
            Console.WriteLine("Inside class A:"+name);
        }

        public virtual void methodA(string address)
        {
            Console.WriteLine($"Inside class a {address}");
        }
    }
    class B:A
    {
        public void display(int roll)
        {
            Console.WriteLine("Inside class B:"+roll);
        }
        public override void methodA(string address)
        {
            base.methodA(address);
            Console.WriteLine("Inside class B " + address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.show("Suman");
            b.display(9);
            b.methodA("Khudrun");
            //A ref b obj
            A a = new B();
            a.show("Anik");
            a.methodA("Kolkata");
        }
    }
}
