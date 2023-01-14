using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void mydelegate(string msg);
    class A
    {
        public  void show(string message)
        {
            Console.WriteLine(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)

        {
            A a = new A();
            mydelegate obj = new mydelegate(a.show);
            obj("Hello world");
        }
    }
}
