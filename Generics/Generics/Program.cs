using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericEx<T>
    {
        T x;
        public GenericEx(T x)
        {
            this.x = x;
            Console.WriteLine(x);
        }
        public void method<T>(T[] value)
        {
            foreach(var item in value)
            {
                Console.WriteLine(item);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr=new int[4] {10,20,30,40};
            GenericEx<int> obj = new GenericEx<int>(10);
            obj.method(arr);


            string[] name = new string[3] { "Suman", "Anik", "Apu" };
            GenericEx<string> obj1 = new GenericEx<string>("Hello world");
            obj1.method(name);
        }
    }
}
