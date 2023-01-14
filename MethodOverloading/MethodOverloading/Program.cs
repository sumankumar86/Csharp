using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class A
    {
        public int methoda(int a,int b)
        {
            return a+b;
        } 
        public int methoda(int a,int b,int c)
        {
            return a+b+c;
        }
        public virtual string show(string msg)
        {
            Console.WriteLine("in class A {msg}");
            return msg;
        }
    }
    class B : A
    {
        public override string show(string msg)
        {
            Console.WriteLine("in class A");
            return msg;
        }
        public string methoda(int a, int b,string name)
        {
            return a + b+name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b=new B();
            b.methoda(1,2);
           // b.methoda(3,5,8);
            //b.methoda(3,5,"Hello");
            string msg=b.show("Hello world");
           
            Console.WriteLine(msg);
            Console.WriteLine(b.methoda(3, 5, 8));
            Console.WriteLine(b.methoda(3, 5, "Hello"));
        }
    }
}
