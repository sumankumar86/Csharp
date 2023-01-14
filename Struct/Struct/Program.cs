using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Exp{
        int a, b;
        public Exp(int num1,int num2)
        {
            a = num1;
            b = num2;
        }
        public int show()
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Exp obj = new Exp(10,20);
            int result=obj.show();
            Console.WriteLine(result);
            
        }
    }
}
