using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUncheckException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            checked
            {
                 int c = int.MaxValue;
                Console.WriteLine("The value of c is {0}", c+2);
            }
            */
            unchecked

            {
             
                int c = int.MaxValue;
                Console.WriteLine("The value of c is {0}", c+2);
            }
            Console.WriteLine("Rest of the code");
        }
    }
}
