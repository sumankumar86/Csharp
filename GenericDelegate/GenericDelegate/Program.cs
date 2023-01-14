using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    public delegate T mydelegate<T>(T param1,T param2);
    class A
    {
        public static int methdodA(int a,int b)
        {
            return a+b;
        }
        public static string methdodB(string a,string b)
        {
            return a+b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            mydelegate<int> obj1 = new mydelegate<int>(A.methdodA);
            mydelegate<string> obj2 = new mydelegate<string>(A.methdodB);
            Console.WriteLine(obj1(10, 20));
            Console.WriteLine(obj2("Hello", "World"));
            
         
        }
    }
}
