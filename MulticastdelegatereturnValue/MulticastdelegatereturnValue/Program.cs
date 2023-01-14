using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastdelegatereturnValue
{
    public delegate int mydelegate();
    class A
    {
        public static int methodA()
        {
            return 100;
        } 
        public static int methodB()
        {
            return 200;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            mydelegate obj1 = new mydelegate(A.methodA);
            mydelegate obj2 = new mydelegate(A.methodB);
            mydelegate obj=obj1+ obj2;
            Console.WriteLine(obj());
        }
    }
}
