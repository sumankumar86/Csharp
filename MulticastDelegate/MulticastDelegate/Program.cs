using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate void exampledelegate(int num);
    class Example
    {
        public static void methodA(int num)
        {
            num *= num;
            Console.WriteLine("In methodA The number is {0}",num);
        }
        public static void methodB(int num)
        {
            num += num;
            Console.WriteLine("In methodB The number is {0}",num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            exampledelegate obj1 = new exampledelegate(Example.methodA);
            exampledelegate obj2 = new exampledelegate(Example.methodB);

            exampledelegate obj = obj1+obj2;
            obj(10);
            exampledelegate obj3=(int num)=>Console.WriteLine("The number is "+num); 
            obj+=obj3;
            obj(11);
        }
    }
}
