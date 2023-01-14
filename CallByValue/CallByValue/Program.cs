using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue
{
    class CallByValueFunction
    {
        public void display(int num)
        {
            num*= num;
            Console.WriteLine("The number is {0}",num);
        }
        public void show(ref int num)
        {
            num*= num;
            Console.WriteLine("The number is {0}",num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 100;
            CallByValueFunction obj = new CallByValueFunction();
            Console.WriteLine("value before calling the function"+val);
            obj.display(val);
            Console.WriteLine("value after calling the function"+val);
            obj.show(ref val);
            Console.WriteLine("Value after sending ref is{0}", val);
        }
    }
}
