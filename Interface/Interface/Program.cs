using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Example{
        void getRate(int a);
    }
    class A : Example
    {
        public void getRate(int a)
        {
            Console.WriteLine("Inside class A"+a);
        }
    }
    #region B
    class B : Example
    {
        public void getRate(int v)
        {
            Console.WriteLine("Inside class B"+v);

        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.getRate(12);

            B b = new B();
            b.getRate(15);

        }
    }
}
